using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_EJIT_V1_M09_5_PDC_b14426_b14426_b14426_
    {
        [Fact]
        public void _CLR_x86_EJIT_V1_M09_5_PDC_b14426_b14426_b14426_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\V1-M09.5-PDC\\b14426\\b14426\\b14426.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
