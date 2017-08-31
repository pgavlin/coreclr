using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorReturn_ro_VectorReturn_ro_
    {
        [Fact]
        public void _VectorReturn_ro_VectorReturn_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorReturn_ro\\VectorReturn_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
