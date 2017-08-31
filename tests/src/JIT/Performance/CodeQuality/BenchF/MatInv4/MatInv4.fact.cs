using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_MatInv4_MatInv4_MatInv4_
    {
        [Fact]
        public void _CodeQuality_BenchF_MatInv4_MatInv4_MatInv4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\MatInv4\\MatInv4\\MatInv4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
