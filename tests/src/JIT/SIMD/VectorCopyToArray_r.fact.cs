using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorCopyToArray_r_VectorCopyToArray_r_
    {
        [Fact]
        public void _VectorCopyToArray_r_VectorCopyToArray_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCopyToArray_r\\VectorCopyToArray_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
