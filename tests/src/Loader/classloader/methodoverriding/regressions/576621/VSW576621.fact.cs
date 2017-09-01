using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _methodoverriding_regressions_576621_VSW576621_VSW576621_
    {
        [OuterLoop]
        [Fact]
        public void _methodoverriding_regressions_576621_VSW576621_VSW576621_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\methodoverriding\\regressions\\576621\\VSW576621\\VSW576621.cmd");
        }
    }
}
