using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b111130_b111130_b111130_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b111130_b111130_b111130_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b111130\\b111130\\b111130.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
