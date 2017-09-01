using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b09452_b09452_b09452_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b09452_b09452_b09452_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b09452\\b09452\\b09452.cmd");
        }
    }
}
