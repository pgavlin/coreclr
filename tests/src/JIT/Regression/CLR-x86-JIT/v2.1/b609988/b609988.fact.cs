using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_b609988_b609988_b609988_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_b609988_b609988_b609988_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\b609988\\b609988\\b609988.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
