using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct6_struct6_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct6_struct6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct6\\struct6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
