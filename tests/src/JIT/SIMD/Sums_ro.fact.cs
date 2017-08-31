using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Sums_ro_Sums_ro_
    {
        [Fact]
        public void _Sums_ro_Sums_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Sums_ro\\Sums_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
