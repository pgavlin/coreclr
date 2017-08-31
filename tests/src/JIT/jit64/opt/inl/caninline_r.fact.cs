using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_inl_caninline_r_caninline_r_
    {
        [Fact]
        public void _opt_inl_caninline_r_caninline_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\inl\\caninline_r\\caninline_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
