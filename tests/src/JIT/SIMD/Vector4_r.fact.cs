using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector4_r_Vector4_r_
    {
        [Fact]
        public void _Vector4_r_Vector4_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector4_r\\Vector4_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
