using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_9param_9param_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_9param_9param_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\9param\\9param.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
