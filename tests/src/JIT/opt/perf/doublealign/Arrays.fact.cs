using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _perf_doublealign_Arrays_Arrays_
    {
        [Fact]
        public void _perf_doublealign_Arrays_Arrays_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\perf\\doublealign\\Arrays\\Arrays.cmd");
        }
    }
}
