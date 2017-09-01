using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Pinning_PinningOther_PinnedMany_PinnedMany_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedMany_PinnedMany_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedMany\\PinnedMany.cmd");
        }
    }
}
