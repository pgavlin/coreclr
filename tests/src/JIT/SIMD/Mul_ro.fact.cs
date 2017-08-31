using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Mul_ro_Mul_ro_
    {
        [Fact]
        public void _Mul_ro_Mul_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Mul_ro\\Mul_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
