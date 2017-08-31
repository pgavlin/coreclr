using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b103838_b103838_b103838_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b103838_b103838_b103838_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b103838\\b103838\\b103838.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
