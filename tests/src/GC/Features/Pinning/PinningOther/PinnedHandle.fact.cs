using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Pinning_PinningOther_PinnedHandle_PinnedHandle_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedHandle_PinnedHandle_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedHandle\\PinnedHandle.cmd");
        }
    }
}
