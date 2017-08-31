using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M09_b16102_b16102_b16102_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b16102_b16102_b16102_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b16102\\b16102\\b16102.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
