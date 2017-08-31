using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Pinning_PinningOther_PinnedMany_PinnedMany_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedMany_PinnedMany_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedMany\\PinnedMany.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
