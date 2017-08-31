using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_Dev10_844071_Dev10_844071_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_Dev10_844071_Dev10_844071_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\Dev10_844071\\Dev10_844071.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
