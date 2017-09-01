using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_lim_lim_001_lim_001_
    {
        [OuterLoop]
        [Fact]
        public void _opt_lim_lim_001_lim_001_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\lim\\lim_001\\lim_001.cmd");
        }
    }
}
