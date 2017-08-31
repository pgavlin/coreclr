using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct4_struct4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct4_struct4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct4\\struct4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
