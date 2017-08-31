using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_526434_dev10_526434_dev10_526434_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_526434_dev10_526434_dev10_526434_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_526434\\dev10_526434\\dev10_526434.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
