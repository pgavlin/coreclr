using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structret2_1_structret2_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret2_1_structret2_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret2_1\\structret2_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
