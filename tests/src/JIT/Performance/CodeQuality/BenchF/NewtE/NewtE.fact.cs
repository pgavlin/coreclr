using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_NewtE_NewtE_NewtE_
    {
        [Fact]
        public void _CodeQuality_BenchF_NewtE_NewtE_NewtE_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\NewtE\\NewtE\\NewtE.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
