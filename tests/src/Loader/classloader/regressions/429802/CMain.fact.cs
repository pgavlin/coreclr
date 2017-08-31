using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_429802_CMain_CMain_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_429802_CMain_CMain_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\429802\\CMain\\CMain.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
