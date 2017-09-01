using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_EJIT_V1_M11_Beta1_b40138_b40138_b40138_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_V1_M11_Beta1_b40138_b40138_b40138_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M11-Beta1\\b40138\\b40138\\b40138.cmd");
        }
    }
}
