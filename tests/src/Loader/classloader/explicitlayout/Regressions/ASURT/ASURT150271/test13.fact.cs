using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_Regressions_ASURT_ASURT150271_test13_test13_
    {
        [Fact]
        public void _explicitlayout_Regressions_ASURT_ASURT150271_test13_test13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\ASURT\\ASURT150271\\test13\\test13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
