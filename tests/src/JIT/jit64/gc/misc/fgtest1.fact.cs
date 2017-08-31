using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_fgtest1_fgtest1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_fgtest1_fgtest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\fgtest1\\fgtest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
