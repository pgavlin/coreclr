using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M10_b08109_b08109_b08109_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b08109_b08109_b08109_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b08109\\b08109\\b08109.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
