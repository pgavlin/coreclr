using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_backwardleaveincatch_r_backwardleaveincatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_backwardleaveincatch_r_backwardleaveincatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\backwardleaveincatch_r\\backwardleaveincatch_r.cmd");
        }
    }
}
