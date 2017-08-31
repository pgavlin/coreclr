using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_109968_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_109968_test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\109968\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
