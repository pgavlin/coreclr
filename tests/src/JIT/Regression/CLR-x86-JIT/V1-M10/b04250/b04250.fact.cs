using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M10_b04250_b04250_b04250_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b04250_b04250_b04250_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b04250\\b04250\\b04250.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
