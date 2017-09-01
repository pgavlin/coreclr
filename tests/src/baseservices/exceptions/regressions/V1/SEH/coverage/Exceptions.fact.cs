using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_coverage_Exceptions_Exceptions_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_coverage_Exceptions_Exceptions_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\coverage\\Exceptions\\Exceptions.cmd");
        }
    }
}
