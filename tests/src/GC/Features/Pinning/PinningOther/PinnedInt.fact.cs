using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Pinning_PinningOther_PinnedInt_PinnedInt_
    {
        [OuterLoop]
        [Fact]
        public void _Pinning_PinningOther_PinnedInt_PinnedInt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedInt\\PinnedInt.cmd");
        }
    }
}
