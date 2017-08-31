using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_443322_dev10_443322_dev10_443322_
    {
        [Fact]
        public void _regressions_dev10_443322_dev10_443322_dev10_443322_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_443322\\dev10_443322\\dev10_443322.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
