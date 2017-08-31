using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorGet_ro_VectorGet_ro_
    {
        [Fact]
        public void _VectorGet_ro_VectorGet_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorGet_ro\\VectorGet_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
