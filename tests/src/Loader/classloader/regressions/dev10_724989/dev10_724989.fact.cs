using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_724989_dev10_724989_dev10_724989_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_724989_dev10_724989_dev10_724989_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_724989\\dev10_724989\\dev10_724989.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
