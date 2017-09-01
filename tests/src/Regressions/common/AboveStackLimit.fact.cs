using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _AboveStackLimit_AboveStackLimit_
    {
        [Fact]
        public void _AboveStackLimit_AboveStackLimit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\AboveStackLimit\\AboveStackLimit.cmd");
        }
    }
}
