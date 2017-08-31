using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_memorystream_MemoryStreamCtor5_MemoryStreamCtor5_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_memorystream_MemoryStreamCtor5_MemoryStreamCtor5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\memorystream\\MemoryStreamCtor5\\MemoryStreamCtor5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
