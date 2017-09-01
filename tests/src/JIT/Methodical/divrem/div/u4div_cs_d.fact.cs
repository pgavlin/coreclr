using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_u4div_cs_d_u4div_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_u4div_cs_d_u4div_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\u4div_cs_d\\u4div_cs_d.cmd");
        }
    }
}
