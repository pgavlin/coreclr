using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_403582_dev10_403582_dev10_403582_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_403582_dev10_403582_dev10_403582_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_403582\\dev10_403582\\dev10_403582.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
