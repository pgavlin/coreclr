using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b09287_b09287_b09287_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b09287_b09287_b09287_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b09287\\b09287\\b09287.cmd");
        }
    }
}
