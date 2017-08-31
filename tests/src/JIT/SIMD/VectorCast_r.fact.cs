using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorCast_r_VectorCast_r_
    {
        [Fact]
        public void _VectorCast_r_VectorCast_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCast_r\\VectorCast_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
