using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_LVNumCnt0_LVNumCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVNumCnt0_LVNumCnt0_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVNumCnt0\\LVNumCnt0.cmd");
        }
    }
}
