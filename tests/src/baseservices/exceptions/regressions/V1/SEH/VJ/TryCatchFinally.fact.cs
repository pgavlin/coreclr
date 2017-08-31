using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_VJ_TryCatchFinally_TryCatchFinally_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_TryCatchFinally_TryCatchFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\TryCatchFinally\\TryCatchFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
