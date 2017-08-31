using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V2_0_RTM_b460385_b460385_b460385_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V2_0_RTM_b460385_b460385_b460385_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V2.0-RTM\\b460385\\b460385\\b460385.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
