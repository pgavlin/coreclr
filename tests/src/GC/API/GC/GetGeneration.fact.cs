using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_GetGeneration_GetGeneration_
    {
        [Fact]
        public void _GC_GetGeneration_GetGeneration_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\GetGeneration\\GetGeneration.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
