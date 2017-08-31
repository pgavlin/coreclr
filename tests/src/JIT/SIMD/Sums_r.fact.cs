using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Sums_r_Sums_r_
    {
        [Fact]
        public void _Sums_r_Sums_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Sums_r\\Sums_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
