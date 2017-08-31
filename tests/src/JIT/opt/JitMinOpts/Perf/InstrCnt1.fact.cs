using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _JitMinOpts_Perf_InstrCnt1_InstrCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_InstrCnt1_InstrCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\InstrCnt1\\InstrCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
