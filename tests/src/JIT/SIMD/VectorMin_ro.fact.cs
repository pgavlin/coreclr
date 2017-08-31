using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMin_ro_VectorMin_ro_
    {
        [Fact]
        public void _VectorMin_ro_VectorMin_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMin_ro\\VectorMin_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
