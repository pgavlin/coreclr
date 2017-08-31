using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_2_Beta1_b147147_b147147_b147147_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b147147_b147147_b147147_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b147147\\b147147\\b147147.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
