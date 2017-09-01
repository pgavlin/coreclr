using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_inl_caninline_ro_caninline_ro_
    {
        [Fact]
        public void _opt_inl_caninline_ro_caninline_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\inl\\caninline_ro\\caninline_ro.cmd");
        }
    }
}
