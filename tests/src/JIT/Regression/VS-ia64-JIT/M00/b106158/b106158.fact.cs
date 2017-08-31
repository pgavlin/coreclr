using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b106158_b106158_b106158_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b106158_b106158_b106158_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b106158\\b106158\\b106158.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
