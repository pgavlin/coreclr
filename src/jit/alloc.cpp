// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#include "jitpch.h"

#if defined(_MSC_VER)
#pragma hdrstop
#endif // defined(_MSC_VER)

//------------------------------------------------------------------------
// PooledAllocator:
//    This subclass of `ArenaAllocator` is a singleton that always keeps
//    a single default-sized page allocated. We try to use the singleton
//    allocator as often as possible (i.e. for all non-concurrent
//    method compilations).
class PooledAllocator : public ArenaAllocator
{
private:
    enum
    {
        POOLED_ALLOCATOR_NOTINITIALIZED = 0,
        POOLED_ALLOCATOR_IN_USE         = 1,
        POOLED_ALLOCATOR_AVAILABLE      = 2,
        POOLED_ALLOCATOR_SHUTDOWN       = 3,
    };

    static PooledAllocator s_pooledAllocator;
    static LONG            s_pooledAllocatorState;

    PooledAllocator() : ArenaAllocator()
    {
    }
    PooledAllocator(IEEMemoryManager* memoryManager);

    PooledAllocator(const PooledAllocator& other) = delete;
    PooledAllocator& operator=(const PooledAllocator& other) = delete;

public:
    PooledAllocator& operator=(PooledAllocator&& other);

    void destroy() override;

    static void shutdown();

    static ArenaAllocator* getPooledAllocator(IEEMemoryManager* memoryManager);
};

size_t ArenaAllocator::s_defaultPageSize = 0;

//------------------------------------------------------------------------
// ArenaAllocator::bypassHostAllocator:
//    Indicates whether or not the ArenaAllocator should bypass the JIT
//    host when allocating memory for arena pages.
//
// Return Value:
//    True if the JIT should bypass the JIT host; false otherwise.
bool ArenaAllocator::bypassHostAllocator()
{
#if defined(DEBUG)
    // When JitDirectAlloc is set, all JIT allocations requests are forwarded
    // directly to the OS. This allows taking advantage of pageheap and other gflag
    // knobs for ensuring that we do not have buffer overruns in the JIT.

    return JitConfig.JitDirectAlloc() != 0;
#else  // defined(DEBUG)
    return false;
#endif // !defined(DEBUG)
}

//------------------------------------------------------------------------
// ArenaAllocator::getDefaultPageSize:
//    Returns the default size of an arena page.
//
// Return Value:
//    The default size of an arena page.
size_t ArenaAllocator::getDefaultPageSize()
{
    return s_defaultPageSize;
}

//------------------------------------------------------------------------
// ArenaAllocator::ArenaAllocator:
//    Default-constructs an arena allocator.
ArenaAllocator::ArenaAllocator()
    : m_memoryManager(nullptr)
    , m_firstPage(nullptr)
    , m_lastPage(nullptr)
    , m_nextFreeByte(nullptr)
    , m_lastFreeByte(nullptr)
{
}

//------------------------------------------------------------------------
// ArenaAllocator::ArenaAllocator:
//    Constructs an arena allocator.
//
// Arguments:
//    memoryManager - The `IEEMemoryManager` instance that will be used to
//                    allocate memory for arena pages.
ArenaAllocator::ArenaAllocator(IEEMemoryManager* memoryManager)
    : m_memoryManager(memoryManager)
    , m_firstPage(nullptr)
    , m_lastPage(nullptr)
    , m_nextFreeByte(nullptr)
    , m_lastFreeByte(nullptr)
{
    assert(getDefaultPageSize() != 0);
    assert(isInitialized());
}

//------------------------------------------------------------------------
// ArenaAllocator::operator=:
//    Move-assigns a `ArenaAllocator`.
ArenaAllocator& ArenaAllocator::operator=(ArenaAllocator&& other)
{
    assert(!isInitialized());

    m_memoryManager = other.m_memoryManager;
    m_firstPage     = other.m_firstPage;
    m_lastPage      = other.m_lastPage;
    m_nextFreeByte  = other.m_nextFreeByte;
    m_lastFreeByte  = other.m_lastFreeByte;

    other.m_memoryManager = nullptr;
    other.m_firstPage     = nullptr;
    other.m_lastPage      = nullptr;
    other.m_nextFreeByte  = nullptr;
    other.m_lastFreeByte  = nullptr;

    return *this;
}

bool ArenaAllocator::isInitialized()
{
    return m_memoryManager != nullptr;
}

//------------------------------------------------------------------------
// ArenaAllocator::allocateNewPage:
//    Allocates a new arena page.
//
// Arguments:
//    size - The number of bytes that were requested by the allocation
//           that triggered this request to allocate a new arena page.
//
// Return Value:
//    A pointer to the first usable byte of the newly allocated page.
void* ArenaAllocator::allocateNewPage(size_t size, bool canThrow)
{
    assert(isInitialized());

    size_t pageSize = sizeof(PageDescriptor) + size;

    // Check for integer overflow
    if (pageSize < size)
    {
        if (canThrow)
        {
            NOMEM();
        }

        return nullptr;
    }

    // If the current page is now full, update a few statistics
    if (m_lastPage != nullptr)
    {
        // Undo the "+=" done in allocateMemory()
        m_nextFreeByte -= size;

        // Save the actual used size of the page
        m_lastPage->m_usedBytes = m_nextFreeByte - m_lastPage->m_contents;
    }

    // Round up to a default-sized page if necessary
    if (pageSize <= s_defaultPageSize)
    {
        pageSize = s_defaultPageSize;
    }

    // Round to the nearest multiple of OS page size if necessary
    if (!bypassHostAllocator())
    {
        pageSize = roundUp(pageSize, DEFAULT_PAGE_SIZE);
    }

#if defined(DEBUG)
    // In debug builds, we need space for the block map
    size_t blockMapSize = (((pageSize / 32) + (((pageSize % 32) != 0) ? 1 : 0)) * 2) / 8;
#endif

    // Allocate the new page
    PageDescriptor* newPage = (PageDescriptor*)allocateHostMemory(pageSize);
    if (newPage == nullptr)
    {
        if (canThrow)
        {
            NOMEM();
        }

        return nullptr;
    }

    // Append the new page to the end of the list
    newPage->m_next      = nullptr;
    newPage->m_pageBytes = pageSize;
    newPage->m_previous  = m_lastPage;
    newPage->m_usedBytes = 0; // m_usedBytes is meaningless until a new page is allocated.
                              // Instead of letting it contain garbage (so to confuse us),
                              // set it to zero.

    if (m_lastPage != nullptr)
    {
        m_lastPage->m_next = newPage;
    }
    else
    {
        m_firstPage = newPage;
    }

    m_lastPage = newPage;

    size_t blockOffset = 0;
#if defined(DEBUG)
    // In debug builds, we need to zero the block map and align the first allocatable byte
    // to 32 bytes.
    size_t pageContents = reinterpret_cast<uintptr_t>(newPage->m_contents);
    blockOffset = roundUp(pageContents + blockMapSize, 32) - pageContents;
    newPage->m_firstBlockOffset = blockOffset;

    memset(newPage->m_contents, 0, blockMapSize);
#endif

    // Adjust the next/last free byte pointers
    m_nextFreeByte = newPage->m_contents + blockOffset + size;
    m_lastFreeByte = (BYTE*)newPage + pageSize;
    assert((m_lastFreeByte - m_nextFreeByte) >= 0);

    return newPage->m_contents + blockOffset;
}

//------------------------------------------------------------------------
// ArenaAllocator::destroy:
//    Performs any necessary teardown for an `ArenaAllocator`.
void ArenaAllocator::destroy()
{
    assert(isInitialized());

    // Free all of the allocated pages
    for (PageDescriptor *page = m_firstPage, *next; page != nullptr; page = next)
    {
        next = page->m_next;
        freeHostMemory(page);
    }

    // Clear out the allocator's fields
    m_memoryManager = nullptr;
    m_firstPage     = nullptr;
    m_lastPage      = nullptr;
    m_nextFreeByte  = nullptr;
    m_lastFreeByte  = nullptr;
}

// The debug version of the allocator may allocate directly from the
// OS rather than going through the hosting APIs. In order to do so,
// it must undef the macros that are usually in place to prevent
// accidental uses of the OS allocator.
#if defined(DEBUG)
#undef GetProcessHeap
#undef HeapAlloc
#undef HeapFree
#endif

//------------------------------------------------------------------------
// ArenaAllocator::allocateHostMemory:
//    Allocates memory from the host (or the OS if `bypassHostAllocator()`
//    returns `true`).
//
// Arguments:
//    size - The number of bytes to allocate.
//
// Return Value:
//    A pointer to the allocated memory.
void* ArenaAllocator::allocateHostMemory(size_t size)
{
    assert(isInitialized());

#if defined(DEBUG)
    if (bypassHostAllocator())
    {
        return ::HeapAlloc(GetProcessHeap(), 0, size);
    }
    else
    {
        return ClrAllocInProcessHeap(0, S_SIZE_T(size));
    }
#else  // defined(DEBUG)
    return m_memoryManager->ClrVirtualAlloc(nullptr, size, MEM_COMMIT, PAGE_READWRITE);
#endif // !defined(DEBUG)
}

//------------------------------------------------------------------------
// ArenaAllocator::freeHostMemory:
//    Frees memory allocated by a previous call to `allocateHostMemory`.
//
// Arguments:
//    block - A pointer to the memory to free.
void ArenaAllocator::freeHostMemory(void* block)
{
    assert(isInitialized());

#if defined(DEBUG)
    if (bypassHostAllocator())
    {
        ::HeapFree(GetProcessHeap(), 0, block);
    }
    else
    {
        ClrFreeInProcessHeap(0, block);
    }
#else  // defined(DEBUG)
    m_memoryManager->ClrVirtualFree(block, 0, MEM_RELEASE);
#endif // !defined(DEBUG)
}

#if defined(DEBUG)
//------------------------------------------------------------------------
// ArenaAllocator::alloateMemory:
//    Allocates memory using an `ArenaAllocator`.
//
// Arguments:
//    size - The number of bytes to allocate.
//
// Return Value:
//    A pointer to the allocated memory.
//
// Note:
//    This is the DEBUG-only version of `allocateMemory`; the release
//    version of this method is defined in the corresponding header file.
//    This version of the method has some abilities that the release
//    version does not: it may inject faults into the allocator and
//    seeds all allocations with a specified pattern to help catch
//    use-before-init problems.
void* ArenaAllocator::allocateMemory(size_t size)
{
    assert(isInitialized());
    assert(size != 0 && (size & (sizeof(int) - 1)) == 0);

    // Ensure that we always allocate in 32-byte increments.
    size = (size_t)roundUp(size, 32);

    if (JitConfig.ShouldInjectFault() != 0)
    {
        // Force the underlying memory allocator (either the OS or the CLR hoster)
        // to allocate the memory. Any fault injection will kick in.
        void* p = ClrAllocInProcessHeap(0, S_SIZE_T(1));
        if (p != nullptr)
        {
            ClrFreeInProcessHeap(0, p);
        }
        else
        {
            NOMEM(); // Throw!
        }
    }

    void* block = m_nextFreeByte;
    m_nextFreeByte += size;

    if (m_nextFreeByte > m_lastFreeByte)
    {
        block = allocateNewPage(size, true);
    }

    // Update the block map.
    assert(getBlockMapEntry(m_lastPage, block) == 0);
    updateBlockMapEntry(m_lastPage, block, 0x1, 0x0);

    memset(block, UninitializedWord<char>(), size);
    return block;
}

void ArenaAllocator::getBlockMapIndex(PageDescriptor* page, void* address, size_t* byteIndex, size_t* bitIndex)
{
    assert(page != nullptr);
    assert(byteIndex != nullptr);
    assert(bitIndex != nullptr);
    assert(address >= (page->m_contents + page->m_firstBlockOffset));
    assert(address < (reinterpret_cast<BYTE*>(page) + page->m_pageBytes));
    assert((reinterpret_cast<uintptr_t>(address) % 32) == 0);
    assert((reinterpret_cast<uintptr_t>(page->m_contents + page->m_firstBlockOffset) % 32) == 0);

    size_t blockIndex = ((reinterpret_cast<BYTE*>(address) - (page->m_contents + page->m_firstBlockOffset)) / 32) * 2;
    *byteIndex = blockIndex / 8;
    *bitIndex = blockIndex % 8;

    assert(*byteIndex < page->m_firstBlockOffset);
}

BYTE ArenaAllocator::getBlockMapEntry(PageDescriptor* page, void* address)
{
    size_t byteIndex = 0, bitIndex = 0;
    getBlockMapIndex(page, address, &byteIndex, &bitIndex);
    return (page->m_contents[byteIndex] >> bitIndex) & 0x3;
}

void ArenaAllocator::updateBlockMapEntry(PageDescriptor* page, void* address, BYTE set, BYTE clear)
{
    size_t byteIndex = 0, bitIndex = 0;
    getBlockMapIndex(page, address, &byteIndex, &bitIndex);

    BYTE* blockMap = page->m_contents;
    BYTE blockByte = blockMap[byteIndex];
    blockMap[byteIndex] = (blockByte | (set << bitIndex)) & ~(clear << bitIndex);
}

void ArenaAllocator::mark(uintptr_t address)
{
    uintptr_t cursor = address;

    // Check to see if the address points into any of this allocator's pages
    PageDescriptor* containingPage = nullptr;
    for (PageDescriptor* page = m_firstPage; page != nullptr; page = page->m_next)
    {
        if (cursor >= reinterpret_cast<uintptr_t>(page->m_contents + page->m_firstBlockOffset) &&
            cursor < (reinterpret_cast<uintptr_t>(page) + page->m_usedBytes))
        {
            containingPage = page;
            break;
        }
    }
    if (containingPage == nullptr)
    {
        return;
    }

    // Look for the block containing this cursor
    cursor &= ~31;
    size_t byteIndex, bitIndex;
    getBlockMapIndex(containingPage, reinterpret_cast<void*>(cursor), &byteIndex, &bitIndex);

    BYTE* blockMap = containingPage->m_contents;
    while ((((blockMap[byteIndex] >> bitIndex) & 0x3) == 0) && (byteIndex > 0 || bitIndex > 0))
    {
        cursor -= 32;
        if (bitIndex == 0)
        {
            byteIndex--;
            bitIndex = 6;
        }
        else
        {
            bitIndex -= 2;
        }
    }

    // The block must have been allocated.
    assert(((blockMap[byteIndex] >> bitIndex) & 0x1) == 0x1);

    // If this block has already been marked, skip it.
    if (((blockMap[byteIndex] >> bitIndex) & 0x2) != 0)
    {
        return;
    }

    // Otherwise, mark the block live and recurse through it.
    blockMap[byteIndex] |= 0x2 << bitIndex;

    size_t blockMapEntries = (containingPage->m_usedBytes / 32) + (((containingPage->m_usedBytes % 32) != 0) ? 1 : 0);
    size_t maxByteIndex = (2 * blockMapEntries) / 8;
    size_t maxBitIndex = (2 * blockMapEntries) % 8;

    size_t blockSize = 0;
    do
    {
        if (bitIndex == 6)
        {
            byteIndex++;
            bitIndex = 0;
        }
        else
        {
            bitIndex += 2;
        }
        blockSize += 32;
    } while ((((blockMap[byteIndex] >> bitIndex) & 0x3) == 0) && (byteIndex < maxByteIndex || bitIndex < maxBitIndex));

    for (size_t byteOffset = 0; byteOffset < blockSize; byteOffset += sizeof(uintptr_t*))
    {
        uintptr_t address = *reinterpret_cast<uintptr_t*>(cursor + byteOffset);
        mark(address);
    }
}

size_t ArenaAllocator::getTotalLiveBytes(size_t* deadBytes)
{
    uintptr_t stackBase = reinterpret_cast<uintptr_t>(ClrTeb::GetStackBase());

    // Make sure the last page has its occupied bytes set correctly
    if (m_lastPage != nullptr)
    {
        m_lastPage->m_usedBytes = m_nextFreeByte - m_lastPage->m_contents;
    }

    // Recursively mark any blocks rooted
    for (uintptr_t cursor = reinterpret_cast<uintptr_t>(&stackBase); cursor < stackBase; cursor += sizeof(void*))
    {
        uintptr_t address = *reinterpret_cast<uintptr_t*>(cursor);
        mark(address);
    }

    // Walk the blocks in each page, accumulate the total number of live bytes,
    // and unmark the live blocks.
    size_t liveBytes = 0;
    size_t totalBytes = 0;
    for (PageDescriptor* page = m_firstPage; page != nullptr; page = page->m_next)
    {
        BYTE* blockMap = page->m_contents;
        size_t blockMapEntries = (page->m_usedBytes / 32) + (((page->m_usedBytes % 32) != 0) ? 1 : 0);
        for (size_t index = 1, blockStart = 0; index <= blockMapEntries; index++)
        {
            if (index < blockMapEntries)
            {
                size_t byteIndex = (2 * index) / 8;
                size_t bitIndex = (2 * index) % 8;
                BYTE blockEntry = (blockMap[byteIndex] >> bitIndex) & 0x3;
                if (blockEntry == 0)
                {
                    continue;
                }
            }

            size_t byteIndex = (2 * blockStart) / 8;
            size_t bitIndex = (2 * blockStart) % 8;
            BYTE blockEntry = (blockMap[byteIndex] >> bitIndex) & 0x3;
            assert((blockEntry & 0x1) != 0);

            if ((blockEntry & 0x2) != 0)
            {
                blockMap[byteIndex] = blockMap[byteIndex] & ~(0x2 << bitIndex);
                liveBytes += (index - blockStart) * 32;
            }

            blockStart = index;
        }

        totalBytes += page->m_usedBytes;
    }

    *deadBytes = totalBytes - liveBytes;
    return liveBytes;
}

#endif // defined(DEBUG)

//------------------------------------------------------------------------
// ArenaAllocator::getTotalBytesAllocated:
//    Gets the total number of bytes allocated for all of the arena pages
//    for an `ArenaAllocator`.
//
// Return Value:
//    See above.
size_t ArenaAllocator::getTotalBytesAllocated()
{
    assert(isInitialized());

    size_t bytes = 0;
    for (PageDescriptor* page = m_firstPage; page != nullptr; page = page->m_next)
    {
        bytes += page->m_pageBytes;
    }

    return bytes;
}

//------------------------------------------------------------------------
// ArenaAllocator::getTotalBytesAllocated:
//    Gets the total number of bytes used in all of the arena pages for
//    an `ArenaAllocator`.
//
// Return Value:
//    See above.
//
// Notes:
//    An arena page may have unused space at the very end. This happens
//    when an allocation request comes in (via a call to `allocateMemory`)
//    that will not fit in the remaining bytes for the current page.
//    Another way to understand this method is as returning the total
//    number of bytes allocated for arena pages minus the number of bytes
//    that are unused across all area pages.
size_t ArenaAllocator::getTotalBytesUsed()
{
    assert(isInitialized());

    if (m_lastPage != nullptr)
    {
        m_lastPage->m_usedBytes = m_nextFreeByte - m_lastPage->m_contents;
    }

    size_t bytes = 0;
    for (PageDescriptor* page = m_firstPage; page != nullptr; page = page->m_next)
    {
        bytes += page->m_usedBytes;
    }

    return bytes;
}

//------------------------------------------------------------------------
// ArenaAllocator::startup:
//    Performs any necessary initialization for the arena allocator
//    subsystem.
void ArenaAllocator::startup()
{
    s_defaultPageSize = bypassHostAllocator() ? (size_t)MIN_PAGE_SIZE : (size_t)DEFAULT_PAGE_SIZE;
}

//------------------------------------------------------------------------
// ArenaAllocator::shutdown:
//    Performs any necessary teardown for the arena allocator subsystem.
void ArenaAllocator::shutdown()
{
    PooledAllocator::shutdown();
}

PooledAllocator PooledAllocator::s_pooledAllocator;
LONG            PooledAllocator::s_pooledAllocatorState = POOLED_ALLOCATOR_NOTINITIALIZED;

//------------------------------------------------------------------------
// PooledAllocator::PooledAllocator:
//    Constructs a `PooledAllocator`.
PooledAllocator::PooledAllocator(IEEMemoryManager* memoryManager) : ArenaAllocator(memoryManager)
{
}

//------------------------------------------------------------------------
// PooledAllocator::operator=:
//    Move-assigns a `PooledAllocator`.
PooledAllocator& PooledAllocator::operator=(PooledAllocator&& other)
{
    *((ArenaAllocator*)this) = std::move((ArenaAllocator &&)other);
    return *this;
}

//------------------------------------------------------------------------
// PooledAllocator::shutdown:
//    Performs any necessary teardown for the pooled allocator.
//
// Notes:
//    If the allocator has been initialized and is in use when this method is called,
//    it is up to whatever is using the pooled allocator to call `destroy` in order
//    to free its memory.
void PooledAllocator::shutdown()
{
    LONG oldState = InterlockedExchange(&s_pooledAllocatorState, POOLED_ALLOCATOR_SHUTDOWN);
    switch (oldState)
    {
        case POOLED_ALLOCATOR_NOTINITIALIZED:
        case POOLED_ALLOCATOR_SHUTDOWN:
        case POOLED_ALLOCATOR_IN_USE:
            return;

        case POOLED_ALLOCATOR_AVAILABLE:
            // The pooled allocator was initialized and not in use; we must destroy it.
            s_pooledAllocator.destroy();
            break;
    }
}

//------------------------------------------------------------------------
// PooledAllocator::getPooledAllocator:
//    Returns the pooled allocator if it is not already in use.
//
// Arguments:
//    memoryManager: The `IEEMemoryManager` instance in use by the caller.
//
// Return Value:
//    A pointer to the pooled allocator if it is available or `nullptr`
//    if it is already in use.
//
// Notes:
//    Calling `destroy` on the returned allocator will return it to the
//    pool.
ArenaAllocator* PooledAllocator::getPooledAllocator(IEEMemoryManager* memoryManager)
{
    LONG oldState = InterlockedExchange(&s_pooledAllocatorState, POOLED_ALLOCATOR_IN_USE);
    switch (oldState)
    {
        case POOLED_ALLOCATOR_IN_USE:
        case POOLED_ALLOCATOR_SHUTDOWN:
            // Either the allocator is in use or this call raced with a call to `shutdown`.
            // Return `nullptr`.
            return nullptr;

        case POOLED_ALLOCATOR_AVAILABLE:
            if (s_pooledAllocator.m_memoryManager != memoryManager)
            {
                // The allocator is available, but it was initialized with a different
                // memory manager. Release it and return `nullptr`.
                InterlockedExchange(&s_pooledAllocatorState, POOLED_ALLOCATOR_AVAILABLE);
                return nullptr;
            }

            return &s_pooledAllocator;

        case POOLED_ALLOCATOR_NOTINITIALIZED:
        {
            PooledAllocator allocator(memoryManager);
            if (allocator.allocateNewPage(0, false) == nullptr)
            {
                // Failed to grab the initial memory page.
                InterlockedExchange(&s_pooledAllocatorState, POOLED_ALLOCATOR_NOTINITIALIZED);
                return nullptr;
            }

            s_pooledAllocator = std::move(allocator);
        }

            return &s_pooledAllocator;

        default:
            assert(!"Unknown pooled allocator state");
            unreached();
    }
}

//------------------------------------------------------------------------
// PooledAllocator::destroy:
//    Performs any necessary teardown for an `PooledAllocator` and returns the allocator
//    to the pool.
void PooledAllocator::destroy()
{
    assert(isInitialized());
    assert(this == &s_pooledAllocator);
    assert(s_pooledAllocatorState == POOLED_ALLOCATOR_IN_USE || s_pooledAllocatorState == POOLED_ALLOCATOR_SHUTDOWN);
    assert(m_firstPage != nullptr);

    // Free all but the first allocated page
    for (PageDescriptor *page = m_firstPage->m_next, *next; page != nullptr; page = next)
    {
        next = page->m_next;
        freeHostMemory(page);
    }

    // Reset the relevant state to point back to the first byte of the first page
    m_firstPage->m_next = nullptr;
    m_lastPage          = m_firstPage;
    m_nextFreeByte      = m_firstPage->m_contents;
    m_lastFreeByte      = (BYTE*)m_firstPage + m_firstPage->m_pageBytes;

    // In debug mode, we need to adjust for the block map
#if defined(DEBUG)
    m_nextFreeByte += m_firstPage->m_firstBlockOffset;
    memset(m_firstPage->m_contents, 0, m_firstPage->m_firstBlockOffset);
#endif

    assert(getTotalBytesAllocated() == s_defaultPageSize);

    // If we've already been shut down, free the first page. Otherwise, return the allocator to the pool.
    if (s_pooledAllocatorState == POOLED_ALLOCATOR_SHUTDOWN)
    {
        ArenaAllocator::destroy();
    }
    else
    {
        InterlockedExchange(&s_pooledAllocatorState, POOLED_ALLOCATOR_AVAILABLE);
    }
}

//------------------------------------------------------------------------
// ArenaAllocator::getPooledAllocator:
//    Returns the pooled allocator if it is not already in use.
//
// Arguments:
//    memoryManager: The `IEEMemoryManager` instance in use by the caller.
//
// Return Value:
//    A pointer to the pooled allocator if it is available or `nullptr`
//    if it is already in use.
//
// Notes:
//    Calling `destroy` on the returned allocator will return it to the
//    pool.
ArenaAllocator* ArenaAllocator::getPooledAllocator(IEEMemoryManager* memoryManager)
{
    return PooledAllocator::getPooledAllocator(memoryManager);
}
