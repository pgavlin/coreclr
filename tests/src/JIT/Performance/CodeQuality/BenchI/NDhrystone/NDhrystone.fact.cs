using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_NDhrystone_NDhrystone_NDhrystone_
    {
        [Fact]
        public void _CodeQuality_BenchI_NDhrystone_NDhrystone_NDhrystone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\NDhrystone\\NDhrystone\\NDhrystone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
