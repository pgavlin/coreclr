using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structfp5_1_structfp5_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp5_1_structfp5_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp5_1\\structfp5_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
