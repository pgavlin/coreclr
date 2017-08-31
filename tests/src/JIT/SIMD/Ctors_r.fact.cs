using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Ctors_r_Ctors_r_
    {
        [Fact]
        public void _Ctors_r_Ctors_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Ctors_r\\Ctors_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
