using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dd116295_dd116295_dd116295_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dd116295_dd116295_dd116295_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dd116295\\dd116295\\dd116295.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
