using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_commutativecse_ccse_cs_d_ccse_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_commutativecse_ccse_cs_d_ccse_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\commutativecse\\ccse_cs_d\\ccse_cs_d.cmd");
        }
    }
}
