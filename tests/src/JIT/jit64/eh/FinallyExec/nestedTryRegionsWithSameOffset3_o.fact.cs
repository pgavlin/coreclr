using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nestedTryRegionsWithSameOffset3_o_nestedTryRegionsWithSameOffset3_o_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nestedTryRegionsWithSameOffset3_o_nestedTryRegionsWithSameOffset3_o_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nestedTryRegionsWithSameOffset3_o\\nestedTryRegionsWithSameOffset3_o.cmd");
        }
    }
}
