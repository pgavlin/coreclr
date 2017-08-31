using CoreclrTestLib;
using Xunit;

namespace JIT_RyuJIT
{
    class _DoWhileBndChk_DoWhileBndChk_
    {
        [Fact]
        public void _DoWhileBndChk_DoWhileBndChk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\RyuJIT\\DoWhileBndChk\\DoWhileBndChk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
