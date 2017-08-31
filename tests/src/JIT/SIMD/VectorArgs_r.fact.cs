using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorArgs_r_VectorArgs_r_
    {
        [Fact]
        public void _VectorArgs_r_VectorArgs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArgs_r\\VectorArgs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
