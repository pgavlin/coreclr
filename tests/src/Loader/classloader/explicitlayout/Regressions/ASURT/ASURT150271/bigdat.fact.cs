using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_Regressions_ASURT_ASURT150271_bigdat_bigdat_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_Regressions_ASURT_ASURT150271_bigdat_bigdat_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\ASURT\\ASURT150271\\bigdat\\bigdat.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
