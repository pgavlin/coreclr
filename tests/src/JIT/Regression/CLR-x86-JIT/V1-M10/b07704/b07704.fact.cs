using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b07704_b07704_b07704_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b07704_b07704_b07704_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b07704\\b07704\\b07704.cmd");
        }
    }
}
