using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_COOL_rethrow_rethrow_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_COOL_rethrow_rethrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\COOL\\rethrow\\rethrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
