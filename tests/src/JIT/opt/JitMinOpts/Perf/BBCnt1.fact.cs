using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_BBCnt1_BBCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_BBCnt1_BBCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\BBCnt1\\BBCnt1.cmd");
        }
    }
}
