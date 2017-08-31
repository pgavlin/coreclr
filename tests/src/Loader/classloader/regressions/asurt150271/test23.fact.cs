using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_asurt150271_test23_test23_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_asurt150271_test23_test23_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\asurt150271\\test23\\test23.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
