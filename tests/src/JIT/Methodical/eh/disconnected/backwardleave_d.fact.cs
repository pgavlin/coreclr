using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_backwardleave_d_backwardleave_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_backwardleave_d_backwardleave_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\backwardleave_d\\backwardleave_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
