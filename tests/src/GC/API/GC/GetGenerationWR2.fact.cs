using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_GetGenerationWR2_GetGenerationWR2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_GetGenerationWR2_GetGenerationWR2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\GetGenerationWR2\\GetGenerationWR2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
