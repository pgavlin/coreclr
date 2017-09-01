using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_M01_b16378_b16378_b16378_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M01_b16378_b16378_b16378_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M01\\b16378\\b16378\\b16378.cmd");
        }
    }
}
