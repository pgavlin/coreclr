using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector3Interop_r_Vector3Interop_r_
    {
        [Fact]
        public void _Vector3Interop_r_Vector3Interop_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3Interop_r\\Vector3Interop_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
