using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nestedTryRegionsWithSameOffset3_nestedTryRegionsWithSameOffset3_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nestedTryRegionsWithSameOffset3_nestedTryRegionsWithSameOffset3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nestedTryRegionsWithSameOffset3\\nestedTryRegionsWithSameOffset3.cmd");
        }
    }
}
