using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_DDB_b19679_b19679_b19679_
    {
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_b19679_b19679_b19679_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\b19679\\b19679\\b19679.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
