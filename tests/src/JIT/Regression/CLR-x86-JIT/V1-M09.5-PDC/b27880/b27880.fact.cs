using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M09_5_PDC_b27880_b27880_b27880_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_5_PDC_b27880_b27880_b27880_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09.5-PDC\\b27880\\b27880\\b27880.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
