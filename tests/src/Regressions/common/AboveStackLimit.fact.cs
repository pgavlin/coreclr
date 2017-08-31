using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _AboveStackLimit_AboveStackLimit_
    {
        [Fact]
        public void _AboveStackLimit_AboveStackLimit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\AboveStackLimit\\AboveStackLimit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
