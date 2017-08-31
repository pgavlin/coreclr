using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_b561129_b561129_b561129_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_b561129_b561129_b561129_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\b561129\\b561129\\b561129.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
