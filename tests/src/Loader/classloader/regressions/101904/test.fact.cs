using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_101904_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_101904_test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\101904\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
