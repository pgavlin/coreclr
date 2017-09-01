using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _9414_readonlyPrefix_readonlyPrefix_
    {
        [OuterLoop]
        [Fact]
        public void _9414_readonlyPrefix_readonlyPrefix_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\9414\\readonlyPrefix\\readonlyPrefix.cmd");
        }
    }
}
