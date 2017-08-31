using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_ioexception_IOExceptionctor1_IOExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_ioexception_IOExceptionctor1_IOExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\ioexception\\IOExceptionctor1\\IOExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
