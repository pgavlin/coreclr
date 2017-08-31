using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_GetGeneration_box_GetGeneration_box_
    {
        [OuterLoop]
        [Fact]
        public void _GC_GetGeneration_box_GetGeneration_box_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\GetGeneration_box\\GetGeneration_box.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
