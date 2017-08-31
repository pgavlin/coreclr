using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_asurt150271_test3_test3_
    {
        [Fact]
        public void _regressions_asurt150271_test3_test3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\asurt150271\\test3\\test3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
