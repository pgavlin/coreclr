using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structfp1_2_structfp1_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_2_structfp1_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_2\\structfp1_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
