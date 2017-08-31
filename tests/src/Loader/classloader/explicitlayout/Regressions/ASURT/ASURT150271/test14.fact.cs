using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_Regressions_ASURT_ASURT150271_test14_test14_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_Regressions_ASURT_ASURT150271_test14_test14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\ASURT\\ASURT150271\\test14\\test14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
