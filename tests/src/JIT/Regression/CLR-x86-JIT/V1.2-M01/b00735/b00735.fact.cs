using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_M01_b00735_b00735_b00735_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M01_b00735_b00735_b00735_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M01\\b00735\\b00735\\b00735.cmd");
        }
    }
}
