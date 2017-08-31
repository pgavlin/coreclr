using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_LLoops_LLoops_LLoops_
    {
        [Fact]
        public void _CodeQuality_BenchF_LLoops_LLoops_LLoops_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\LLoops\\LLoops\\LLoops.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
