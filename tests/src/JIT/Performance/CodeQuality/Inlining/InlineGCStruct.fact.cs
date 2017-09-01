using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_Inlining_InlineGCStruct_InlineGCStruct_
    {
        [Fact]
        public void _CodeQuality_Inlining_InlineGCStruct_InlineGCStruct_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Inlining\\InlineGCStruct\\InlineGCStruct.cmd");
        }
    }
}
