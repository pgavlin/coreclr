using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_DDB_B168384_LdfldaHack_LdfldaHack_
    {
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_B168384_LdfldaHack_LdfldaHack_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\B168384\\LdfldaHack\\LdfldaHack.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
