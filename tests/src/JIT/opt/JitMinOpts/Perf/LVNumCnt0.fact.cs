using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_LVNumCnt0_LVNumCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVNumCnt0_LVNumCnt0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVNumCnt0\\LVNumCnt0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
