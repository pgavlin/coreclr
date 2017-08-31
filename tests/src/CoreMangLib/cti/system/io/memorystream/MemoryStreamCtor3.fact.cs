using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_memorystream_MemoryStreamCtor3_MemoryStreamCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_memorystream_MemoryStreamCtor3_MemoryStreamCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\memorystream\\MemoryStreamCtor3\\MemoryStreamCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
