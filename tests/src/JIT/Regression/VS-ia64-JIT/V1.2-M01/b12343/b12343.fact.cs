using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M01_b12343_b12343_b12343_
    {
        [Fact]
        public void _VS_ia64_JIT_V1_2_M01_b12343_b12343_b12343_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M01\\b12343\\b12343\\b12343.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
