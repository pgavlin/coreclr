using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_GetGeneration_GetGeneration_
    {
        [Fact]
        public void _GC_GetGeneration_GetGeneration_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\GetGeneration\\GetGeneration.cmd");
        }
    }
}
