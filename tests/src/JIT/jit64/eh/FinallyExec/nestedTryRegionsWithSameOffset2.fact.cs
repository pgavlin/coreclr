using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nestedTryRegionsWithSameOffset2_nestedTryRegionsWithSameOffset2_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nestedTryRegionsWithSameOffset2_nestedTryRegionsWithSameOffset2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nestedTryRegionsWithSameOffset2\\nestedTryRegionsWithSameOffset2.cmd");
        }
    }
}
