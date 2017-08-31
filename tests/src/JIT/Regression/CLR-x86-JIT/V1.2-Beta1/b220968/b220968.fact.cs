using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_2_Beta1_b220968_b220968_b220968_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b220968_b220968_b220968_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b220968\\b220968\\b220968.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
