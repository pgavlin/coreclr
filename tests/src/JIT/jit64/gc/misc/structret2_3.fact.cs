using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structret2_3_structret2_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret2_3_structret2_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret2_3\\structret2_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
