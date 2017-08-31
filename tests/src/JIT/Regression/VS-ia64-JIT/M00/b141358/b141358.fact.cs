using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b141358_b141358_b141358_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b141358_b141358_b141358_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b141358\\b141358\\b141358.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
