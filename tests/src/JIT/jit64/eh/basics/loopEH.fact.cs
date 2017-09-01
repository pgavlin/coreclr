using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_basics_loopEH_loopEH_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_loopEH_loopEH_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\loopEH\\loopEH.cmd");
        }
    }
}
