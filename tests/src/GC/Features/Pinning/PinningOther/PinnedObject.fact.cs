using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Pinning_PinningOther_PinnedObject_PinnedObject_
    {
        [Fact]
        public void _Pinning_PinningOther_PinnedObject_PinnedObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Pinning\\PinningOther\\PinnedObject\\PinnedObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
