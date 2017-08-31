using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_710121_dev10_710121_dev10_710121_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_710121_dev10_710121_dev10_710121_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_710121\\dev10_710121\\dev10_710121.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
