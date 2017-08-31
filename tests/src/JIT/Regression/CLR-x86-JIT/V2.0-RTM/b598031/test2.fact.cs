using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_RTM_b598031_test2_test2_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b598031_test2_test2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b598031\\test2\\test2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
