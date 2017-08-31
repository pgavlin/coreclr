using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_EJIT_V1_M09_5_PDC_b16935_b16935_b16935_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_V1_M09_5_PDC_b16935_b16935_b16935_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M09.5-PDC\\b16935\\b16935\\b16935.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
