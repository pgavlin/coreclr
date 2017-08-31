using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_2_M02_b30251_b30251_b30251_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M02_b30251_b30251_b30251_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M02\\b30251\\b30251\\b30251.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
