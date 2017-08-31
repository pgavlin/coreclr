using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_RTM_b487372_b487372_b487372_
    {
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b487372_b487372_b487372_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b487372\\b487372\\b487372.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
