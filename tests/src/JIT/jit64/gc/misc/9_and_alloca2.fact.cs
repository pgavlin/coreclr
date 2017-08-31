using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_9_and_alloca2_9_and_alloca2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_9_and_alloca2_9_and_alloca2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\9_and_alloca2\\9_and_alloca2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
