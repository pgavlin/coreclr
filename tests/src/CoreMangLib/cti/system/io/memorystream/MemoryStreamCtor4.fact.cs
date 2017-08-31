using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_memorystream_MemoryStreamCtor4_MemoryStreamCtor4_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_memorystream_MemoryStreamCtor4_MemoryStreamCtor4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\memorystream\\MemoryStreamCtor4\\MemoryStreamCtor4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
