using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _RunBenchmarks_RunBenchmarks_RunBenchmarks_
    {
        [Fact]
        public void _RunBenchmarks_RunBenchmarks_RunBenchmarks_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\RunBenchmarks\\RunBenchmarks\\RunBenchmarks.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
