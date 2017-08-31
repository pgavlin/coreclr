using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_backwardleave_r_backwardleave_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_backwardleave_r_backwardleave_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\backwardleave_r\\backwardleave_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
