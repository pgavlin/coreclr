using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_asm_NestedExcept_NestedExcept_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_NestedExcept_NestedExcept_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\NestedExcept\\NestedExcept.cmd");
        }
    }
}
