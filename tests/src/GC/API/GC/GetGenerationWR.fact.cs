using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_GetGenerationWR_GetGenerationWR_
    {
        [Fact]
        public void _GC_GetGenerationWR_GetGenerationWR_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\GetGenerationWR\\GetGenerationWR.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
