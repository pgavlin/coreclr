using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_COOL_rethrow_rethrow_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_COOL_rethrow_rethrow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\COOL\\rethrow\\rethrow.cmd");
        }
    }
}
