using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_EJIT_v1_m10_b02353_b02353_b02353_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_EJIT_v1_m10_b02353_b02353_b02353_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-EJIT\\v1-m10\\b02353\\b02353\\b02353.cmd");
        }
    }
}
