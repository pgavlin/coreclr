using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V2_0_RTM_b604247_b604247_b604247_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b604247_b604247_b604247_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b604247\\b604247\\b604247.cmd");
        }
    }
}
