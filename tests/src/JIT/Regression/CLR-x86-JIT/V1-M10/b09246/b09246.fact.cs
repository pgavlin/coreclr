using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b09246_b09246_b09246_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b09246_b09246_b09246_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b09246\\b09246\\b09246.cmd");
        }
    }
}
