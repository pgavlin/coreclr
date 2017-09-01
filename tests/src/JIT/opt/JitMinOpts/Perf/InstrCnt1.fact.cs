using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_InstrCnt1_InstrCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_InstrCnt1_InstrCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\InstrCnt1\\InstrCnt1.cmd");
        }
    }
}
