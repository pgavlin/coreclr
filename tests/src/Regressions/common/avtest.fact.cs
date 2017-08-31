using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _avtest_avtest_
    {
        [Fact]
        public void _avtest_avtest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\avtest\\avtest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
