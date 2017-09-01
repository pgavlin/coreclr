using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_QFE_b151440_params_varargs_params_varargs_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_QFE_b151440_params_varargs_params_varargs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-QFE\\b151440\\params-varargs\\params-varargs.cmd");
        }
    }
}
