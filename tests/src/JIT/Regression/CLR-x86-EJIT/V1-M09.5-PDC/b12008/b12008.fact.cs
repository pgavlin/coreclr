using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_EJIT_V1_M09_5_PDC_b12008_b12008_b12008_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_V1_M09_5_PDC_b12008_b12008_b12008_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M09.5-PDC\\b12008\\b12008\\b12008.cmd");
        }
    }
}
