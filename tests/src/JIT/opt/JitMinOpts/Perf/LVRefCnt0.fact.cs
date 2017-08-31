using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_LVRefCnt0_LVRefCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVRefCnt0_LVRefCnt0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVRefCnt0\\LVRefCnt0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
