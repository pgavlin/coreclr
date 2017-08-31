using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_1_M1_Beta1_b130333_b130333_b130333_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_1_M1_Beta1_b130333_b130333_b130333_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.1-M1-Beta1\\b130333\\b130333\\b130333.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
