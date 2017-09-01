using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V2_0_Beta2_b323557_b323557_ret_b323557_ret_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_Beta2_b323557_b323557_ret_b323557_ret_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-Beta2\\b323557\\b323557-ret\\b323557-ret.cmd");
        }
    }
}
