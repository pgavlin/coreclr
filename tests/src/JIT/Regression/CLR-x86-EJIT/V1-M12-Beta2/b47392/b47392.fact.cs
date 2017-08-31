using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_EJIT_V1_M12_Beta2_b47392_b47392_b47392_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_V1_M12_Beta2_b47392_b47392_b47392_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M12-Beta2\\b47392\\b47392\\b47392.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
