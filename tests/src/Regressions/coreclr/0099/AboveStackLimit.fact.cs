using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0099_AboveStackLimit_AboveStackLimit_
    {
        [OuterLoop]
        [Fact]
        public void _0099_AboveStackLimit_AboveStackLimit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0099\\AboveStackLimit\\AboveStackLimit.cmd");
        }
    }
}
