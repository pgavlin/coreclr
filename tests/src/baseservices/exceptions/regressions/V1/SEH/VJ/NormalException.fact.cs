using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_VJ_NormalException_NormalException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_NormalException_NormalException_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\NormalException\\NormalException.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
