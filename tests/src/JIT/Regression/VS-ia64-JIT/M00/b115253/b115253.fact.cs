using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b115253_b115253_b115253_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b115253_b115253_b115253_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b115253\\b115253\\b115253.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
