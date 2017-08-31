using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorSub_r_VectorSub_r_
    {
        [Fact]
        public void _VectorSub_r_VectorSub_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSub_r\\VectorSub_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
