using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_BBCnt0_BBCnt0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_BBCnt0_BBCnt0_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\BBCnt0\\BBCnt0.cmd");
        }
    }
}
