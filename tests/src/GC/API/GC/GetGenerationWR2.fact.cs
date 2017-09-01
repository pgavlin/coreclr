using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_GetGenerationWR2_GetGenerationWR2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_GetGenerationWR2_GetGenerationWR2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\GetGenerationWR2\\GetGenerationWR2.cmd");
        }
    }
}
