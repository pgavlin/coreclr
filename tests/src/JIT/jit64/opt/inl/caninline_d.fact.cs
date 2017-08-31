using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_inl_caninline_d_caninline_d_
    {
        [Fact]
        public void _opt_inl_caninline_d_caninline_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\inl\\caninline_d\\caninline_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
