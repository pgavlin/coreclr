using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b98431_b98431_b98431_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b98431_b98431_b98431_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b98431\\b98431\\b98431.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
