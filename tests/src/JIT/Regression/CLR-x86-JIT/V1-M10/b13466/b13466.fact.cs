using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M10_b13466_b13466_b13466_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b13466_b13466_b13466_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b13466\\b13466\\b13466.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
