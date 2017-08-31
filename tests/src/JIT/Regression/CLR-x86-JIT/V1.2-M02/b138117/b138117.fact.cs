using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_2_M02_b138117_b138117_b138117_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M02_b138117_b138117_b138117_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M02\\b138117\\b138117\\b138117.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
