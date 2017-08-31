using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structret4_3_structret4_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret4_3_structret4_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret4_3\\structret4_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
