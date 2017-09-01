using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Pinning_PinningOther_PinnedCollect_PinnedCollect_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedCollect_PinnedCollect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedCollect\\PinnedCollect.cmd");
        }
    }
}
