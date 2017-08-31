using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structfpseh6_1_structfpseh6_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfpseh6_1_structfpseh6_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfpseh6_1\\structfpseh6_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
