using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _RecursiveTailCall_RecursiveTailCall_
    {
        [OuterLoop]
        [Fact]
        public void _RecursiveTailCall_RecursiveTailCall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\RecursiveTailCall\\RecursiveTailCall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
