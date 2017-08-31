using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M13_RTM_b89279_b89279_b89279_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M13_RTM_b89279_b89279_b89279_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M13-RTM\\b89279\\b89279\\b89279.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
