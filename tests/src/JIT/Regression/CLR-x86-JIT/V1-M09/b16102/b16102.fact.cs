using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b16102_b16102_b16102_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b16102_b16102_b16102_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b16102\\b16102\\b16102.cmd");
        }
    }
}
