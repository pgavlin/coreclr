using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b14640_b14640_b14640_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b14640_b14640_b14640_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b14640\\b14640\\b14640.cmd");
        }
    }
}
