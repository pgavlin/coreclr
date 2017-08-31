using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _AbsSqrt_ro_AbsSqrt_ro_
    {
        [Fact]
        public void _AbsSqrt_ro_AbsSqrt_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\AbsSqrt_ro\\AbsSqrt_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
