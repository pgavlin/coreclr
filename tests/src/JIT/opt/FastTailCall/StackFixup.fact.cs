using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _FastTailCall_StackFixup_StackFixup_
    {
        [Fact]
        public void _FastTailCall_StackFixup_StackFixup_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\StackFixup\\StackFixup.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
