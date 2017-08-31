using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M13_RTM_b92066_b92066_b92066_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_M13_RTM_b92066_b92066_b92066_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M13-RTM\\b92066\\b92066\\b92066.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
