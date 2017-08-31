using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_188892_test188892_test188892_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_188892_test188892_test188892_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\188892\\test188892\\test188892.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
