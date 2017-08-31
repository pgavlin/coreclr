using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Pinning_PinningOther_PinnedCollect_PinnedCollect_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedCollect_PinnedCollect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedCollect\\PinnedCollect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
