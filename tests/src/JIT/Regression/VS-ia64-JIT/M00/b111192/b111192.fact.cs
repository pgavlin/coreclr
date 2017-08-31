using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b111192_b111192_b111192_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b111192_b111192_b111192_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b111192\\b111192\\b111192.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
