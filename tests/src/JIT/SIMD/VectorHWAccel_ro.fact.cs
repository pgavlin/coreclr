using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorHWAccel_ro_VectorHWAccel_ro_
    {
        [Fact]
        public void _VectorHWAccel_ro_VectorHWAccel_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel_ro\\VectorHWAccel_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
