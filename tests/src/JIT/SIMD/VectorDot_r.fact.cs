using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorDot_r_VectorDot_r_
    {
        [Fact]
        public void _VectorDot_r_VectorDot_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDot_r\\VectorDot_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
