using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _9414_readonlyPrefix_readonlyPrefix_
    {
        [OuterLoop]
        [Fact]
        public void _9414_readonlyPrefix_readonlyPrefix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\9414\\readonlyPrefix\\readonlyPrefix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
