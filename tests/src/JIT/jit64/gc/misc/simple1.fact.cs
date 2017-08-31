using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_simple1_simple1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_simple1_simple1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\simple1\\simple1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
