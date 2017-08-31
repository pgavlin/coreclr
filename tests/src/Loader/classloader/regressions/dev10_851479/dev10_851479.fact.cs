using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_851479_dev10_851479_dev10_851479_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_851479_dev10_851479_dev10_851479_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_851479\\dev10_851479\\dev10_851479.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
