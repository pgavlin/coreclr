using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_InstrCnt0_InstrCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_InstrCnt0_InstrCnt0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\InstrCnt0\\InstrCnt0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
