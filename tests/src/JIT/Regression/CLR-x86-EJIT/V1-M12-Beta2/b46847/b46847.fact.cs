using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_EJIT_V1_M12_Beta2_b46847_b46847_b46847_
    {
        [Fact]
        public void _CLR_x86_EJIT_V1_M12_Beta2_b46847_b46847_b46847_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M12-Beta2\\b46847\\b46847\\b46847.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
