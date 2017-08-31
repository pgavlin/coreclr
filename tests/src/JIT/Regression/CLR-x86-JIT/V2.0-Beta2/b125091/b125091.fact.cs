using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_Beta2_b125091_b125091_b125091_
    {
        [Fact]
        public void _CLR_x86_JIT_V2_0_Beta2_b125091_b125091_b125091_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-Beta2\\b125091\\b125091\\b125091.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
