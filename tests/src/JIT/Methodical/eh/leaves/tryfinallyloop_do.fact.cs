using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_tryfinallyloop_do_tryfinallyloop_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_tryfinallyloop_do_tryfinallyloop_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyloop_do\\tryfinallyloop_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
