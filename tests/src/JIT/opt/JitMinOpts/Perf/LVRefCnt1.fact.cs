using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_LVRefCnt1_LVRefCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVRefCnt1_LVRefCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVRefCnt1\\LVRefCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
