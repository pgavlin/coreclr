using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_Beta2_b320147_b320147_b320147_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_Beta2_b320147_b320147_b320147_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-Beta2\\b320147\\b320147\\b320147.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
