using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structfpseh5_1_structfpseh5_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfpseh5_1_structfpseh5_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfpseh5_1\\structfpseh5_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
