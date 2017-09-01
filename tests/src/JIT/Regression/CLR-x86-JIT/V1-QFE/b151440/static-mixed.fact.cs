using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_QFE_b151440_static_mixed_static_mixed_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_QFE_b151440_static_mixed_static_mixed_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-QFE\\b151440\\static-mixed\\static-mixed.cmd");
        }
    }
}
