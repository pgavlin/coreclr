using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b05619_b05619_b05619_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b05619_b05619_b05619_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b05619\\b05619\\b05619.cmd");
        }
    }
}
