using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev11_11333_dev11_11333_dev11_11333_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev11_11333_dev11_11333_dev11_11333_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev11_11333\\dev11_11333\\dev11_11333.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
