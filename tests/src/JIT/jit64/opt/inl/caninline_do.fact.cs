using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_inl_caninline_do_caninline_do_
    {
        [Fact]
        public void _opt_inl_caninline_do_caninline_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\inl\\caninline_do\\caninline_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
