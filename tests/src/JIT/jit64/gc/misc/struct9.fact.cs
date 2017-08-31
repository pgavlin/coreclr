using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct9_struct9_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct9_struct9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct9\\struct9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
