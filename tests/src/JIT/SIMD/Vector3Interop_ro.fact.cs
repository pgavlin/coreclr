using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector3Interop_ro_Vector3Interop_ro_
    {
        [Fact]
        public void _Vector3Interop_ro_Vector3Interop_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3Interop_ro\\Vector3Interop_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
