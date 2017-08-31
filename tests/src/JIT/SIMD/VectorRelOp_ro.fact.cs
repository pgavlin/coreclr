using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorRelOp_ro_VectorRelOp_ro_
    {
        [Fact]
        public void _VectorRelOp_ro_VectorRelOp_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorRelOp_ro\\VectorRelOp_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
