using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_b173313_b173313_b173313_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_b173313_b173313_b173313_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\b173313\\b173313\\b173313.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
