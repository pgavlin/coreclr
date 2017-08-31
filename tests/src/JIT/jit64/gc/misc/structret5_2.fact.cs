using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structret5_2_structret5_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret5_2_structret5_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret5_2\\structret5_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
