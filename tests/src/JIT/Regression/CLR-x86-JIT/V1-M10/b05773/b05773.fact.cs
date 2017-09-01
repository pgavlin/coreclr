using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b05773_b05773_b05773_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b05773_b05773_b05773_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b05773\\b05773\\b05773.cmd");
        }
    }
}
