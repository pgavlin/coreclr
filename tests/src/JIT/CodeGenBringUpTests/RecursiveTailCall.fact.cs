using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _RecursiveTailCall_RecursiveTailCall_
    {
        [OuterLoop]
        [Fact]
        public void _RecursiveTailCall_RecursiveTailCall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\RecursiveTailCall\\RecursiveTailCall.cmd");
        }
    }
}
