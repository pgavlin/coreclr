using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_inl_inl001_inl001_
    {
        [OuterLoop]
        [Fact]
        public void _opt_inl_inl001_inl001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\inl\\inl001\\inl001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
