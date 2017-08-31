using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorSet_r_VectorSet_r_
    {
        [Fact]
        public void _VectorSet_r_VectorSet_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSet_r\\VectorSet_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
