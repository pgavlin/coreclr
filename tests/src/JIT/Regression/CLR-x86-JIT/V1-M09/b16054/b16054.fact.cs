using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_b16054_b16054_b16054_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b16054_b16054_b16054_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b16054\\b16054\\b16054.cmd");
        }
    }
}
