using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_Regressions_369794_repro369794_repro369794_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_Regressions_369794_repro369794_repro369794_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\369794\\repro369794\\repro369794.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
