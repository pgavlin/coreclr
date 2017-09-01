using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nestedTryRegionsWithSameOffset2_o_nestedTryRegionsWithSameOffset2_o_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nestedTryRegionsWithSameOffset2_o_nestedTryRegionsWithSameOffset2_o_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nestedTryRegionsWithSameOffset2_o\\nestedTryRegionsWithSameOffset2_o.cmd");
        }
    }
}
