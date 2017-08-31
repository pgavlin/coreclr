using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMul_ro_VectorMul_ro_
    {
        [Fact]
        public void _VectorMul_ro_VectorMul_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMul_ro\\VectorMul_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
