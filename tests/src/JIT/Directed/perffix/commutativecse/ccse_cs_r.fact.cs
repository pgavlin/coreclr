using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_commutativecse_ccse_cs_r_ccse_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_commutativecse_ccse_cs_r_ccse_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\commutativecse\\ccse_cs_r\\ccse_cs_r.cmd");
        }
    }
}
