using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorCopyToArray_ro_VectorCopyToArray_ro_
    {
        [Fact]
        public void _VectorCopyToArray_ro_VectorCopyToArray_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCopyToArray_ro\\VectorCopyToArray_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
