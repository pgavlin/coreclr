using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_InvMt_InvMt_InvMt_
    {
        [Fact]
        public void _CodeQuality_BenchF_InvMt_InvMt_InvMt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\InvMt\\InvMt\\InvMt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
