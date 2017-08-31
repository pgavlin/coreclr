using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorUnused_r_VectorUnused_r_
    {
        [Fact]
        public void _VectorUnused_r_VectorUnused_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorUnused_r\\VectorUnused_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
