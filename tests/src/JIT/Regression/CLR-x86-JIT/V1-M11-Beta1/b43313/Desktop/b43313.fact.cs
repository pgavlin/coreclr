using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M11_Beta1_b43313_Desktop_b43313_b43313_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_M11_Beta1_b43313_Desktop_b43313_b43313_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M11-Beta1\\b43313\\Desktop\\b43313\\b43313.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
