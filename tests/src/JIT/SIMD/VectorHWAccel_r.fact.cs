using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorHWAccel_r_VectorHWAccel_r_
    {
        [Fact]
        public void _VectorHWAccel_r_VectorHWAccel_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel_r\\VectorHWAccel_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
