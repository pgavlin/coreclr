using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b85316_b85316_b85316_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b85316_b85316_b85316_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b85316\\b85316\\b85316.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
