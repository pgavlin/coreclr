using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _AbsSqrt_r_AbsSqrt_r_
    {
        [Fact]
        public void _AbsSqrt_r_AbsSqrt_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\AbsSqrt_r\\AbsSqrt_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
