using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_tryfinallyloop_ro_tryfinallyloop_ro_
    {
        [Fact]
        public void _eh_leaves_tryfinallyloop_ro_tryfinallyloop_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyloop_ro\\tryfinallyloop_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
