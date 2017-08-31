using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0099_AboveStackLimit_AboveStackLimit_
    {
        [OuterLoop]
        [Fact]
        public void _0099_AboveStackLimit_AboveStackLimit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0099\\AboveStackLimit\\AboveStackLimit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
