using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_decimaldiv_cs_d_decimaldiv_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_d_decimaldiv_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_d\\decimaldiv_cs_d.cmd");
        }
    }
}
