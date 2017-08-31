using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_Regula_Regula_Regula_
    {
        [Fact]
        public void _CodeQuality_BenchF_Regula_Regula_Regula_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\Regula\\Regula\\Regula.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
