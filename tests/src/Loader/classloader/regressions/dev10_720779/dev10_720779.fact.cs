using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_720779_dev10_720779_dev10_720779_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_720779_dev10_720779_dev10_720779_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_720779\\dev10_720779\\dev10_720779.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
