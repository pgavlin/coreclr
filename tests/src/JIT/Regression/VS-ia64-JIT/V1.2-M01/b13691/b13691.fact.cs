using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M01_b13691_b13691_b13691_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_M01_b13691_b13691_b13691_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M01\\b13691\\b13691\\b13691.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
