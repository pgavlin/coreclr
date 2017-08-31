using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_basics_loopEH_loopEH_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_loopEH_loopEH_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\loopEH\\loopEH.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
