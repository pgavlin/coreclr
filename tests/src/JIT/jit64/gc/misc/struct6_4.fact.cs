using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct6_4_struct6_4_
    {
        [Fact]
        public void _gc_misc_struct6_4_struct6_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct6_4\\struct6_4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
