using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_UserExceptionThread_UserExceptionThread_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_UserExceptionThread_UserExceptionThread_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\UserExceptionThread\\UserExceptionThread.cmd");
        }
    }
}
