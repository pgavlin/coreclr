using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b13178_b13178_b13178_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b13178_b13178_b13178_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b13178\\b13178\\b13178.cmd");
        }
    }
}
