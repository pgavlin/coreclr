using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_630250_dev10_630250_dev10_630250_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_630250_dev10_630250_dev10_630250_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_630250\\dev10_630250\\dev10_630250.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
