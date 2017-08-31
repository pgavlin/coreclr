using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_osr_osr001_osr001_
    {
        [OuterLoop]
        [Fact]
        public void _opt_osr_osr001_osr001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\osr\\osr001\\osr001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
