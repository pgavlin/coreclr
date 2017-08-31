using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_lim_lim_002_lim_002_
    {
        [OuterLoop]
        [Fact]
        public void _opt_lim_lim_002_lim_002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\lim\\lim_002\\lim_002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
