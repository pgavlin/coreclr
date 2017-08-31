using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Mul_r_Mul_r_
    {
        [OuterLoop]
        [Fact]
        public void _Mul_r_Mul_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Mul_r\\Mul_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
