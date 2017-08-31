using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_CodeSize0_CodeSize0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_CodeSize0_CodeSize0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\CodeSize0\\CodeSize0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
