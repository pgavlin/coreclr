using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b119026_b119026b_b119026b_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b119026_b119026b_b119026b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b119026\\b119026b\\b119026b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
