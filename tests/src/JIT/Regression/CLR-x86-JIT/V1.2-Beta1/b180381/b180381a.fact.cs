using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_Beta1_b180381_b180381a_b180381a_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b180381_b180381a_b180381a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b180381\\b180381a\\b180381a.cmd");
        }
    }
}
