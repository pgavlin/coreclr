using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_tryfinallyloop_r_tryfinallyloop_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_tryfinallyloop_r_tryfinallyloop_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyloop_r\\tryfinallyloop_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
