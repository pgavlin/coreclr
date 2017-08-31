using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_exception_ExceptionGetBaseException_ExceptionGetBaseException_
    {
        [OuterLoop]
        [Fact]
        public void _system_exception_ExceptionGetBaseException_ExceptionGetBaseException_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\exception\\ExceptionGetBaseException\\ExceptionGetBaseException.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
