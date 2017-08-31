using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Pinning_PinningOther_PinnedInt_PinnedInt_
    {
        [OuterLoop]
        [Fact]
        public void _Pinning_PinningOther_PinnedInt_PinnedInt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedInt\\PinnedInt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
