using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_SqMtx_SqMtx_SqMtx_
    {
        [Fact]
        public void _CodeQuality_BenchF_SqMtx_SqMtx_SqMtx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\SqMtx\\SqMtx\\SqMtx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
