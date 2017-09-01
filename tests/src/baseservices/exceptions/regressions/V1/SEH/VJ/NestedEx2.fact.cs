using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_NestedEx2_NestedEx2_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_NestedEx2_NestedEx2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\NestedEx2\\NestedEx2.cmd");
        }
    }
}
