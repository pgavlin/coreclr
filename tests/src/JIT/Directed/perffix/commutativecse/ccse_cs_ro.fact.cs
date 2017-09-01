using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_commutativecse_ccse_cs_ro_ccse_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_commutativecse_ccse_cs_ro_ccse_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\commutativecse\\ccse_cs_ro\\ccse_cs_ro.cmd");
        }
    }
}
