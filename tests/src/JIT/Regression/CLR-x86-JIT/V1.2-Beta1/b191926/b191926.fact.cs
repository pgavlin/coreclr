using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_Beta1_b191926_b191926_b191926_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b191926_b191926_b191926_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b191926\\b191926\\b191926.cmd");
        }
    }
}
