using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_gc_pinned_code_motion_gc_pinned_code_motion_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_gc_pinned_code_motion_gc_pinned_code_motion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\gc-pinned-code-motion\\gc-pinned-code-motion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
