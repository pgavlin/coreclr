using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_Whetsto_Whetsto_Whetsto_
    {
        [Fact]
        public void _CodeQuality_BenchF_Whetsto_Whetsto_Whetsto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\Whetsto\\Whetsto\\Whetsto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
