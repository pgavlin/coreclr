using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_components
{
    class _stopwatch_Co9604get_IsRunning_Co9604get_IsRunning_
    {
        [OuterLoop]
        [Fact]
        public void _stopwatch_Co9604get_IsRunning_Co9604get_IsRunning_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\components\\stopwatch\\Co9604get_IsRunning\\Co9604get_IsRunning.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
