using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _perf_doublealign_objects_objects_
    {
        [OuterLoop]
        [Fact]
        public void _perf_doublealign_objects_objects_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\perf\\doublealign\\objects\\objects.cmd");
        }
    }
}
