using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_493135_dev10_493135_dev10_493135_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_493135_dev10_493135_dev10_493135_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_493135\\dev10_493135\\dev10_493135.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
