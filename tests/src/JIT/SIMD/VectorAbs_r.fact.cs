using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorAbs_r_VectorAbs_r_
    {
        [Fact]
        public void _VectorAbs_r_VectorAbs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAbs_r\\VectorAbs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
