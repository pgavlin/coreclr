using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_Simpsn_Simpsn_Simpsn_
    {
        [Fact]
        public void _CodeQuality_BenchF_Simpsn_Simpsn_Simpsn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\Simpsn\\Simpsn\\Simpsn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
