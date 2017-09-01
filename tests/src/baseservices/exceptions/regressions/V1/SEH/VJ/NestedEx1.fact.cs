using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_NestedEx1_NestedEx1_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_NestedEx1_NestedEx1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\NestedEx1\\NestedEx1.cmd");
        }
    }
}
