using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b81766_b81766_b81766_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b81766_b81766_b81766_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b81766\\b81766\\b81766.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
