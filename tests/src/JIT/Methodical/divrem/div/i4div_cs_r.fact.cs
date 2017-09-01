using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_i4div_cs_r_i4div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_i4div_cs_r_i4div_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\i4div_cs_r\\i4div_cs_r.cmd");
        }
    }
}
