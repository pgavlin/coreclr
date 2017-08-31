using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_coverage_Exceptions_Exceptions_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_coverage_Exceptions_Exceptions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\coverage\\Exceptions\\Exceptions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
