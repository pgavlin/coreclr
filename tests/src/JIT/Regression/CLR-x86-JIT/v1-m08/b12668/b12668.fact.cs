using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v1_m08_b12668_b12668_b12668_
    {
        [Fact]
        public void _CLR_x86_JIT_v1_m08_b12668_b12668_b12668_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v1-m08\\b12668\\b12668\\b12668.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
