using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V2_0_RTM_b518440_b518440_b518440_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b518440_b518440_b518440_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b518440\\b518440\\b518440.cmd");
        }
    }
}
