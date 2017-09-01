using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_LVRefCnt1_LVRefCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_LVRefCnt1_LVRefCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\LVRefCnt1\\LVRefCnt1.cmd");
        }
    }
}
