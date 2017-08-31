using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector3_ro_Vector3_ro_
    {
        [Fact]
        public void _Vector3_ro_Vector3_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3_ro\\Vector3_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
