using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMul_r_VectorMul_r_
    {
        [Fact]
        public void _VectorMul_r_VectorMul_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMul_r\\VectorMul_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
