using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_asm_FiltCatch_FiltCatch_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_FiltCatch_FiltCatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\FiltCatch\\FiltCatch.cmd");
        }
    }
}
