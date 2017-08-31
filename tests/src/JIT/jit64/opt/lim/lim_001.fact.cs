using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_lim_lim_001_lim_001_
    {
        [OuterLoop]
        [Fact]
        public void _opt_lim_lim_001_lim_001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\lim\\lim_001\\lim_001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
