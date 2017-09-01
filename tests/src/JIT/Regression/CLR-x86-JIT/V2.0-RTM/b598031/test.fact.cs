using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V2_0_RTM_b598031_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_RTM_b598031_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-RTM\\b598031\\test\\test.cmd");
        }
    }
}
