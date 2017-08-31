using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorHWAccel2_ro_VectorHWAccel2_ro_
    {
        [Fact]
        public void _VectorHWAccel2_ro_VectorHWAccel2_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel2_ro\\VectorHWAccel2_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
