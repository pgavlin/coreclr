using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_XposMatrix_XposMatrix_XposMatrix_
    {
        [Fact]
        public void _CodeQuality_BenchI_XposMatrix_XposMatrix_XposMatrix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\XposMatrix\\XposMatrix\\XposMatrix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
