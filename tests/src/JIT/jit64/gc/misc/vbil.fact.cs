using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_vbil_vbil_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_vbil_vbil_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\vbil\\vbil.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
