using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_InProd_InProd_InProd_
    {
        [Fact]
        public void _CodeQuality_BenchF_InProd_InProd_InProd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\InProd\\InProd\\InProd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
