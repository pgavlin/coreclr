using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Inlining_InlineGCStruct_InlineGCStruct_
    {
        [Fact]
        public void _CodeQuality_Inlining_InlineGCStruct_InlineGCStruct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Inlining\\InlineGCStruct\\InlineGCStruct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
