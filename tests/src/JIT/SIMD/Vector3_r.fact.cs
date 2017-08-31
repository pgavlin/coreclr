using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector3_r_Vector3_r_
    {
        [Fact]
        public void _Vector3_r_Vector3_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3_r\\Vector3_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
