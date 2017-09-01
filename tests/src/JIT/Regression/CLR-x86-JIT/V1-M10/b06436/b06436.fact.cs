using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b06436_b06436_b06436_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b06436_b06436_b06436_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b06436\\b06436\\b06436.cmd");
        }
    }
}
