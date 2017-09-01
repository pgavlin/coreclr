using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_CodeSize1_CodeSize1_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_CodeSize1_CodeSize1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\CodeSize1\\CodeSize1.cmd");
        }
    }
}
