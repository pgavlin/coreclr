using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_decimaldiv_cs_do_decimaldiv_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_do_decimaldiv_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_do\\decimaldiv_cs_do.cmd");
        }
    }
}
