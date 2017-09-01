using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_InstrCnt0_InstrCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_InstrCnt0_InstrCnt0_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\InstrCnt0\\InstrCnt0.cmd");
        }
    }
}
