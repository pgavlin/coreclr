using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Ldind_r_Ldind_r_
    {
        [OuterLoop]
        [Fact]
        public void _Ldind_r_Ldind_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Ldind_r\\Ldind_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
