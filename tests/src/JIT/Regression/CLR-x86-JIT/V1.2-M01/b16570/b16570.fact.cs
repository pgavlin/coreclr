using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_2_M01_b16570_b16570_b16570_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M01_b16570_b16570_b16570_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M01\\b16570\\b16570\\b16570.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
