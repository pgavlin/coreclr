using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _FastTailCall_FastTailCallCandidates_FastTailCallCandidates_
    {
        [Fact]
        public void _FastTailCall_FastTailCallCandidates_FastTailCallCandidates_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\FastTailCallCandidates\\FastTailCallCandidates.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
