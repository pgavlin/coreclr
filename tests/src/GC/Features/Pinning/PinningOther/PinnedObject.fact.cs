using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Pinning_PinningOther_PinnedObject_PinnedObject_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedObject_PinnedObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedObject\\PinnedObject.cmd");
        }
    }
}
