using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_CodeSize1_CodeSize1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_CodeSize1_CodeSize1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\CodeSize1\\CodeSize1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
