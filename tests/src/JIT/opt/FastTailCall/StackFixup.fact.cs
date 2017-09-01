using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _FastTailCall_StackFixup_StackFixup_
    {
        [Fact]
        public void _FastTailCall_StackFixup_StackFixup_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\StackFixup\\StackFixup.cmd");
        }
    }
}
