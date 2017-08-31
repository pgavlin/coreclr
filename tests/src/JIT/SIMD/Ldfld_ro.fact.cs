using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Ldfld_ro_Ldfld_ro_
    {
        [Fact]
        public void _Ldfld_ro_Ldfld_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Ldfld_ro\\Ldfld_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
