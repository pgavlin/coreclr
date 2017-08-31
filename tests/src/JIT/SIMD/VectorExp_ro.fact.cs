using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorExp_ro_VectorExp_ro_
    {
        [Fact]
        public void _VectorExp_ro_VectorExp_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorExp_ro\\VectorExp_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
