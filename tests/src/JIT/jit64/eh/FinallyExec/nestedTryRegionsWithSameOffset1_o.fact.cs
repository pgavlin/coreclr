using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nestedTryRegionsWithSameOffset1_o_nestedTryRegionsWithSameOffset1_o_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nestedTryRegionsWithSameOffset1_o_nestedTryRegionsWithSameOffset1_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nestedTryRegionsWithSameOffset1_o\\nestedTryRegionsWithSameOffset1_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
