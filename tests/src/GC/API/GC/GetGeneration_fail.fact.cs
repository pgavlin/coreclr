using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_GetGeneration_fail_GetGeneration_fail_
    {
        [Fact]
        public void _GC_GetGeneration_fail_GetGeneration_fail_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\GetGeneration_fail\\GetGeneration_fail.cmd");
        }
    }
}
