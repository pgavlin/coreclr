using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_Beta1_b178128_b178128_b178128_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b178128_b178128_b178128_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b178128\\b178128\\b178128.cmd");
        }
    }
}
