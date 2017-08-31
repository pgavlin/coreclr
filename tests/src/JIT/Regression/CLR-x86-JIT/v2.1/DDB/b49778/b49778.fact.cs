using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_DDB_b49778_b49778_b49778_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_b49778_b49778_b49778_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\b49778\\b49778\\b49778.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
