using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorRelOp_r_VectorRelOp_r_
    {
        [Fact]
        public void _VectorRelOp_r_VectorRelOp_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorRelOp_r\\VectorRelOp_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
