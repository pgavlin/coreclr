using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorDiv_r_VectorDiv_r_
    {
        [Fact]
        public void _VectorDiv_r_VectorDiv_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDiv_r\\VectorDiv_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
