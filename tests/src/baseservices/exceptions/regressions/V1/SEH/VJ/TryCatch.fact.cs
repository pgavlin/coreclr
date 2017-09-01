using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_TryCatch_TryCatch_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_TryCatch_TryCatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\TryCatch\\TryCatch.cmd");
        }
    }
}
