using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorExp_r_VectorExp_r_
    {
        [Fact]
        public void _VectorExp_r_VectorExp_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorExp_r\\VectorExp_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
