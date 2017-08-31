using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorReturn_r_VectorReturn_r_
    {
        [Fact]
        public void _VectorReturn_r_VectorReturn_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorReturn_r\\VectorReturn_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
