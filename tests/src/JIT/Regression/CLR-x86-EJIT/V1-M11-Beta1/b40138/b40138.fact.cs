using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_EJIT_V1_M11_Beta1_b40138_b40138_b40138_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_V1_M11_Beta1_b40138_b40138_b40138_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M11-Beta1\\b40138\\b40138\\b40138.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
