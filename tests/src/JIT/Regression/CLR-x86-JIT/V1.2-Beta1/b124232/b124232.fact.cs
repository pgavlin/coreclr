using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_Beta1_b124232_b124232_b124232_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b124232_b124232_b124232_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b124232\\b124232\\b124232.cmd");
        }
    }
}
