using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b108908_b108908_b108908_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b108908_b108908_b108908_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b108908\\b108908\\b108908.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
