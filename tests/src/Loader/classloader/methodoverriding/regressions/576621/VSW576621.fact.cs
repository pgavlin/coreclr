using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _methodoverriding_regressions_576621_VSW576621_VSW576621_
    {
        [OuterLoop]
        [Fact]
        public void _methodoverriding_regressions_576621_VSW576621_VSW576621_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\methodoverriding\\regressions\\576621\\VSW576621\\VSW576621.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
