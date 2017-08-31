using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorHWAccel2_r_VectorHWAccel2_r_
    {
        [Fact]
        public void _VectorHWAccel2_r_VectorHWAccel2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel2_r\\VectorHWAccel2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
