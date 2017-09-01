using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b06924_b06924_b06924_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b06924_b06924_b06924_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b06924\\b06924\\b06924.cmd");
        }
    }
}
