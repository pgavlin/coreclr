using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M13_RTM_b113239_b113239_b113239_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M13_RTM_b113239_b113239_b113239_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M13-RTM\\b113239\\b113239\\b113239.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
