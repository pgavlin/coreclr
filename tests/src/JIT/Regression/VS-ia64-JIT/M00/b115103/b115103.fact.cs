using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b115103_b115103_b115103_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b115103_b115103_b115103_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b115103\\b115103\\b115103.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
