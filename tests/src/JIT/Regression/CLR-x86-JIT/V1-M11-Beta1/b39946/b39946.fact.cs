using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M11_Beta1_b39946_b39946_b39946_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_M11_Beta1_b39946_b39946_b39946_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M11-Beta1\\b39946\\b39946\\b39946.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
