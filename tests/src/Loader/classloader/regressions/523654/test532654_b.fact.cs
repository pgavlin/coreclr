using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_523654_test532654_b_test532654_b_
    {
        [Fact]
        public void _regressions_523654_test532654_b_test532654_b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\523654\\test532654_b\\test532654_b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
