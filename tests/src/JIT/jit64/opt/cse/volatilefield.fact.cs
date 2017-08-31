using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_volatilefield_volatilefield_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_volatilefield_volatilefield_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\volatilefield\\volatilefield.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
