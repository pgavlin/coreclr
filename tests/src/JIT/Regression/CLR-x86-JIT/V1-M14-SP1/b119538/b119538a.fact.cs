using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M14_SP1_b119538_b119538a_b119538a_
    {
        [Fact]
        public void _CLR_x86_JIT_V1_M14_SP1_b119538_b119538a_b119538a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M14-SP1\\b119538\\b119538a\\b119538a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
