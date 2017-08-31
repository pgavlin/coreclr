using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorArray_r_VectorArray_r_
    {
        [Fact]
        public void _VectorArray_r_VectorArray_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArray_r\\VectorArray_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
