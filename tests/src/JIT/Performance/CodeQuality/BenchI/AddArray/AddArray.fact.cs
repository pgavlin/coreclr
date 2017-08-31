using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_AddArray_AddArray_AddArray_
    {
        [Fact]
        public void _CodeQuality_BenchI_AddArray_AddArray_AddArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\AddArray\\AddArray\\AddArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
