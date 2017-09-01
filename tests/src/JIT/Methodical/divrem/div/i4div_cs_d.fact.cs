using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_i4div_cs_d_i4div_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_i4div_cs_d_i4div_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\i4div_cs_d\\i4div_cs_d.cmd");
        }
    }
}
