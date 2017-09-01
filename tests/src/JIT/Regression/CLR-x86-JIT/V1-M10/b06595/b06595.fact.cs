using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b06595_b06595_b06595_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b06595_b06595_b06595_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b06595\\b06595\\b06595.cmd");
        }
    }
}
