using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b15468_b15468_b15468_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b15468_b15468_b15468_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b15468\\b15468\\b15468.cmd");
        }
    }
}
