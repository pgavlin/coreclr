using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorArray_ro_VectorArray_ro_
    {
        [Fact]
        public void _VectorArray_ro_VectorArray_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArray_ro\\VectorArray_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
