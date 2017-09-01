using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_asm_Finally_Finally_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_Finally_Finally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\Finally\\Finally.cmd");
        }
    }
}
