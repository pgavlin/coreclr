using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b14428_b14428_b14428_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b14428_b14428_b14428_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b14428\\b14428\\b14428.cmd");
        }
    }
}
