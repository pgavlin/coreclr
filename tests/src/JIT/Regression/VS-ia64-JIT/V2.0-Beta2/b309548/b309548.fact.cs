using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V2_0_Beta2_b309548_b309548_b309548_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V2_0_Beta2_b309548_b309548_b309548_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V2.0-Beta2\\b309548\\b309548\\b309548.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
