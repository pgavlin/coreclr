using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorAdd_r_VectorAdd_r_
    {
        [Fact]
        public void _VectorAdd_r_VectorAdd_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAdd_r\\VectorAdd_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
