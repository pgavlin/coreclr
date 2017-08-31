using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M11_Beta1_b45985_b45985_b45985_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M11_Beta1_b45985_b45985_b45985_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M11-Beta1\\b45985\\b45985\\b45985.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
