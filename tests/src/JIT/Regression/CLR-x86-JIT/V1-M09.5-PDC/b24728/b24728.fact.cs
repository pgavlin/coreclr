using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M09_5_PDC_b24728_b24728_b24728_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_5_PDC_b24728_b24728_b24728_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09.5-PDC\\b24728\\b24728\\b24728.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
