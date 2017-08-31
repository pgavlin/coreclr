using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorSqrt_r_VectorSqrt_r_
    {
        [OuterLoop]
        [Fact]
        public void _VectorSqrt_r_VectorSqrt_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSqrt_r\\VectorSqrt_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
