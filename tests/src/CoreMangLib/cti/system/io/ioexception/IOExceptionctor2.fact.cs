using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_ioexception_IOExceptionctor2_IOExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_ioexception_IOExceptionctor2_IOExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\ioexception\\IOExceptionctor2\\IOExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
