using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_LVNumCnt1_LVNumCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVNumCnt1_LVNumCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVNumCnt1\\LVNumCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
