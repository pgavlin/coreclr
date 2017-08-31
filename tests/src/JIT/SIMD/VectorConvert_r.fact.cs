using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorConvert_r_VectorConvert_r_
    {
        [Fact]
        public void _VectorConvert_r_VectorConvert_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorConvert_r\\VectorConvert_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
