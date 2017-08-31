using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b81763_b81763_b81763_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b81763_b81763_b81763_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b81763\\b81763\\b81763.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
