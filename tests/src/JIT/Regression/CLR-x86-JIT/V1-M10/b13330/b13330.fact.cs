using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b13330_b13330_b13330_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b13330_b13330_b13330_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b13330\\b13330\\b13330.cmd");
        }
    }
}
