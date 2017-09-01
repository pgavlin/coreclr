using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b14673_b14673_b14673_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b14673_b14673_b14673_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b14673\\b14673\\b14673.cmd");
        }
    }
}
