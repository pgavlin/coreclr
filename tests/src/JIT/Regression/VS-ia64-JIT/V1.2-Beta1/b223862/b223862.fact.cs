using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_Beta1_b223862_b223862_b223862_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_Beta1_b223862_b223862_b223862_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-Beta1\\b223862\\b223862\\b223862.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
