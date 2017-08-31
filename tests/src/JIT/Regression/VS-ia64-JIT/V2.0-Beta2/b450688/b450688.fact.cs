using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V2_0_Beta2_b450688_b450688_b450688_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V2_0_Beta2_b450688_b450688_b450688_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V2.0-Beta2\\b450688\\b450688\\b450688.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
