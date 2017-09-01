using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M13_RTM_b101147_b101147_b101147_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M13_RTM_b101147_b101147_b101147_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M13-RTM\\b101147\\b101147\\b101147.cmd");
        }
    }
}
