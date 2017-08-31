using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_DMath_DMath_DMath_
    {
        [Fact]
        public void _CodeQuality_BenchF_DMath_DMath_DMath_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\DMath\\DMath\\DMath.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
