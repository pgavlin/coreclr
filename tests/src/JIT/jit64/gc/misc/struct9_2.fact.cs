using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct9_2_struct9_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct9_2_struct9_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct9_2\\struct9_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
