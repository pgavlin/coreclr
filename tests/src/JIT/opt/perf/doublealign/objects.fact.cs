using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _perf_doublealign_objects_objects_
    {
        [OuterLoop]
        [Fact]
        public void _perf_doublealign_objects_objects_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\perf\\doublealign\\objects\\objects.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
