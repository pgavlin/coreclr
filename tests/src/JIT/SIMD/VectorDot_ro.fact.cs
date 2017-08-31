using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorDot_ro_VectorDot_ro_
    {
        [Fact]
        public void _VectorDot_ro_VectorDot_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDot_ro\\VectorDot_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
