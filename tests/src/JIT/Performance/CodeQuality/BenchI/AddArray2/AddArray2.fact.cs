using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_AddArray2_AddArray2_AddArray2_
    {
        [Fact]
        public void _CodeQuality_BenchI_AddArray2_AddArray2_AddArray2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\AddArray2\\AddArray2\\AddArray2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
