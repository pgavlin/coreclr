using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_Dev12_518401_dev12_518401_dev12_518401_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_Dev12_518401_dev12_518401_dev12_518401_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\Dev12_518401\\dev12_518401\\dev12_518401.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
