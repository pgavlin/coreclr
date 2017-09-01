using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_asm_FiltFallThru_FiltFallThru_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_asm_FiltFallThru_FiltFallThru_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\asm\\FiltFallThru\\FiltFallThru.cmd");
        }
    }
}
