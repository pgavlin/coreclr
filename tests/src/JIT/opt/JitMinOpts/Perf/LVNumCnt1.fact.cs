using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_LVNumCnt1_LVNumCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVNumCnt1_LVNumCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVNumCnt1\\LVNumCnt1.cmd");
        }
    }
}
