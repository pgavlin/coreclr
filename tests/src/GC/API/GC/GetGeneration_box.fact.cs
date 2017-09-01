using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_GetGeneration_box_GetGeneration_box_
    {
        [OuterLoop]
        [Fact]
        public void _GC_GetGeneration_box_GetGeneration_box_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\GetGeneration_box\\GetGeneration_box.cmd");
        }
    }
}
