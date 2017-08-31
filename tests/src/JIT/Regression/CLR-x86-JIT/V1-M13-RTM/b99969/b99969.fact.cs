using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M13_RTM_b99969_b99969_b99969_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_M13_RTM_b99969_b99969_b99969_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M13-RTM\\b99969\\b99969\\b99969.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
