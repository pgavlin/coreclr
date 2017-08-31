using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorGet_r_VectorGet_r_
    {
        [Fact]
        public void _VectorGet_r_VectorGet_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorGet_r\\VectorGet_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
