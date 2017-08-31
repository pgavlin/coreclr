using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b114628_b114628_b114628_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b114628_b114628_b114628_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b114628\\b114628\\b114628.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
