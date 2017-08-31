using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_794943_dev10_794943_dev10_794943_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_794943_dev10_794943_dev10_794943_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_794943\\dev10_794943\\dev10_794943.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
