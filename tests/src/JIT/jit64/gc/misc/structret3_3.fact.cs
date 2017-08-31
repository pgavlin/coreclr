using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structret3_3_structret3_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret3_3_structret3_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret3_3\\structret3_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
