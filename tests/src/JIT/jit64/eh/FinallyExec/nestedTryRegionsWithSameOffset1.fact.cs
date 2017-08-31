using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nestedTryRegionsWithSameOffset1_nestedTryRegionsWithSameOffset1_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nestedTryRegionsWithSameOffset1_nestedTryRegionsWithSameOffset1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nestedTryRegionsWithSameOffset1\\nestedTryRegionsWithSameOffset1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
