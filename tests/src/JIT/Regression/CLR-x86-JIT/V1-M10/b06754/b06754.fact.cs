using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b06754_b06754_b06754_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b06754_b06754_b06754_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b06754\\b06754\\b06754.cmd");
        }
    }
}
