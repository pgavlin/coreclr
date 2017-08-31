using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_Regressions_ASURT_ASURT150271_test10_test10_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_Regressions_ASURT_ASURT150271_test10_test10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\ASURT\\ASURT150271\\test10\\test10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
