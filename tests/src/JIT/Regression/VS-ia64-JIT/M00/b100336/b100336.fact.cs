using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b100336_b100336_b100336_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b100336_b100336_b100336_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b100336\\b100336\\b100336.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
