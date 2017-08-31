using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_BBCnt0_BBCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_BBCnt0_BBCnt0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\BBCnt0\\BBCnt0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
