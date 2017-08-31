using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMin_r_VectorMin_r_
    {
        [Fact]
        public void _VectorMin_r_VectorMin_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMin_r\\VectorMin_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
