using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_COOL_finally_finally_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_COOL_finally_finally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\COOL\\finally\\finally.cmd");
        }
    }
}
