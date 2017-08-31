using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_DDB_b33183_b33183_b33183_
    {
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_b33183_b33183_b33183_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\b33183\\b33183\\b33183.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
