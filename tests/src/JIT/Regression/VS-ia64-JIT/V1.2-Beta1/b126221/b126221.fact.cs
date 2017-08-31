using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_Beta1_b126221_b126221_b126221_
    {
        [Fact]
        public void _VS_ia64_JIT_V1_2_Beta1_b126221_b126221_b126221_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-Beta1\\b126221\\b126221\\b126221.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
