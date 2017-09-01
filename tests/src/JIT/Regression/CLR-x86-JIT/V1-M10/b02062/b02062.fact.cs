using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b02062_b02062_b02062_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b02062_b02062_b02062_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b02062\\b02062\\b02062.cmd");
        }
    }
}
