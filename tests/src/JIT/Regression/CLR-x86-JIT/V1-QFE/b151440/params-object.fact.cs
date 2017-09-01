using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_QFE_b151440_params_object_params_object_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_QFE_b151440_params_object_params_object_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-QFE\\b151440\\params-object\\params-object.cmd");
        }
    }
}
