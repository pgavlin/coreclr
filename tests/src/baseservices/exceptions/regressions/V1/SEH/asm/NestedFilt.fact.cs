using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_asm_NestedFilt_NestedFilt_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_NestedFilt_NestedFilt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\NestedFilt\\NestedFilt.cmd");
        }
    }
}
