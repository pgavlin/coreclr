using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_decimaldiv_cs_r_decimaldiv_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_r_decimaldiv_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_r\\decimaldiv_cs_r.cmd");
        }
    }
}
