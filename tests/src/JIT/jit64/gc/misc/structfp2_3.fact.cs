using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structfp2_3_structfp2_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp2_3_structfp2_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp2_3\\structfp2_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
