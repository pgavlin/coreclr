using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_GetGeneration_fail_GetGeneration_fail_
    {
        [Fact]
        public void _GC_GetGeneration_fail_GetGeneration_fail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\GetGeneration_fail\\GetGeneration_fail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
