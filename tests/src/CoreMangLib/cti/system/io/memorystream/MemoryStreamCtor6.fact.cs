using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_memorystream_MemoryStreamCtor6_MemoryStreamCtor6_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_memorystream_MemoryStreamCtor6_MemoryStreamCtor6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\memorystream\\MemoryStreamCtor6\\MemoryStreamCtor6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
