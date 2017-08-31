using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_QFE_b151440_params_none_params_none_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_QFE_b151440_params_none_params_none_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-QFE\\b151440\\params-none\\params-none.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
