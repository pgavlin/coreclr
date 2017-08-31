using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_NewtR_NewtR_NewtR_
    {
        [Fact]
        public void _CodeQuality_BenchF_NewtR_NewtR_NewtR_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\NewtR\\NewtR\\NewtR.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
