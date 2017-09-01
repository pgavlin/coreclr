using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _JitMinOpts_Perf_CodeSize0_CodeSize0_
    {
        [OuterLoop]
        [Fact]
        public void _JitMinOpts_Perf_CodeSize0_CodeSize0_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\JitMinOpts\\Perf\\CodeSize0\\CodeSize0.cmd");
        }
    }
}
