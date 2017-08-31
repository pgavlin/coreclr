using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_CoreFX_15913_CoreFX_15913_CoreFX_15913_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_CoreFX_15913_CoreFX_15913_CoreFX_15913_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\CoreFX_15913\\CoreFX_15913\\CoreFX_15913.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
