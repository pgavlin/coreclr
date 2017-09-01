using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_r4div_cs_r_r4div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r4div_cs_r_r4div_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r4div_cs_r\\r4div_cs_r.cmd");
        }
    }
}
