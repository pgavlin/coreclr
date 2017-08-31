using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_RTM_b487364_b487364_b487364_
    {
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b487364_b487364_b487364_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b487364\\b487364\\b487364.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
