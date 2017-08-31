using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_VJ_UserExceptionThread_UserExceptionThread_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_UserExceptionThread_UserExceptionThread_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\UserExceptionThread\\UserExceptionThread.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
