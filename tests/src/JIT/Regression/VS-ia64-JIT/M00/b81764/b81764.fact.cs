using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b81764_b81764_b81764_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b81764_b81764_b81764_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b81764\\b81764\\b81764.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
