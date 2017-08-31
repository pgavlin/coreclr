using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_implicitDownConv_implicitDownConv_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_implicitDownConv_implicitDownConv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\implicitDownConv\\implicitDownConv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
