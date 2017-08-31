using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_Beta1_b91944_b91944_b91944_
    {
        [Fact]
        public void _VS_ia64_JIT_V1_2_Beta1_b91944_b91944_b91944_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-Beta1\\b91944\\b91944\\b91944.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
