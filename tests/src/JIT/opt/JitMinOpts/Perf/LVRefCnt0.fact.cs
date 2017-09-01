using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_LVRefCnt0_LVRefCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVRefCnt0_LVRefCnt0_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVRefCnt0\\LVRefCnt0.cmd");
        }
    }
}
