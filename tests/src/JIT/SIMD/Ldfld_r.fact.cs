using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Ldfld_r_Ldfld_r_
    {
        [Fact]
        public void _Ldfld_r_Ldfld_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Ldfld_r\\Ldfld_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
