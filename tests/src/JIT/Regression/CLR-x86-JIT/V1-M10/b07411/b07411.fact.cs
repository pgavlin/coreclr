using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b07411_b07411_b07411_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b07411_b07411_b07411_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b07411\\b07411\\b07411.cmd");
        }
    }
}
