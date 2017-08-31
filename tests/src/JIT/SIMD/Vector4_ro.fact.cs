using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector4_ro_Vector4_ro_
    {
        [Fact]
        public void _Vector4_ro_Vector4_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector4_ro\\Vector4_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
