using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_forwardleaveincatch_r_forwardleaveincatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_forwardleaveincatch_r_forwardleaveincatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\forwardleaveincatch_r\\forwardleaveincatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
