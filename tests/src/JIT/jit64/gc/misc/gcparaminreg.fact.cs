using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_gcparaminreg_gcparaminreg_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_gcparaminreg_gcparaminreg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\gcparaminreg\\gcparaminreg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
