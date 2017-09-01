using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b05621_b05621_b05621_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b05621_b05621_b05621_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b05621\\b05621\\b05621.cmd");
        }
    }
}
