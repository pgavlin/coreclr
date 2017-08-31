using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_memorystream_MemoryStreamCtor2_MemoryStreamCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_memorystream_MemoryStreamCtor2_MemoryStreamCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\memorystream\\MemoryStreamCtor2\\MemoryStreamCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
