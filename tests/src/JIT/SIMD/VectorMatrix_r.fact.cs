using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMatrix_r_VectorMatrix_r_
    {
        [Fact]
        public void _VectorMatrix_r_VectorMatrix_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMatrix_r\\VectorMatrix_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
