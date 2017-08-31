using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Pinning_PinningOther_PinnedHandle_PinnedHandle_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedHandle_PinnedHandle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedHandle\\PinnedHandle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
