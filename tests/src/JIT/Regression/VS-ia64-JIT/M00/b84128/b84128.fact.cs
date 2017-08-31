using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b84128_b84128_b84128_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b84128_b84128_b84128_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b84128\\b84128\\b84128.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
