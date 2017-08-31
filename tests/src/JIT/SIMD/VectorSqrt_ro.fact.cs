using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorSqrt_ro_VectorSqrt_ro_
    {
        [Fact]
        public void _VectorSqrt_ro_VectorSqrt_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSqrt_ro\\VectorSqrt_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
