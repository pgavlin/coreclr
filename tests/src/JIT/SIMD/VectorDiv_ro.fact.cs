using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorDiv_ro_VectorDiv_ro_
    {
        [Fact]
        public void _VectorDiv_ro_VectorDiv_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDiv_ro\\VectorDiv_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
