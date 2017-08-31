using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMatrix_ro_VectorMatrix_ro_
    {
        [Fact]
        public void _VectorMatrix_ro_VectorMatrix_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMatrix_ro\\VectorMatrix_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
