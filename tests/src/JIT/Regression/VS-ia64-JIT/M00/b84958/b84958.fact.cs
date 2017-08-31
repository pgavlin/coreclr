using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b84958_b84958_b84958_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b84958_b84958_b84958_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b84958\\b84958\\b84958.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
