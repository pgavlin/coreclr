using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_decimaldiv_cs_ro_decimaldiv_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_ro_decimaldiv_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_ro\\decimaldiv_cs_ro.cmd");
        }
    }
}
