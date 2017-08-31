using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_395780_testExplicitOverride_testExplicitOverride_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_395780_testExplicitOverride_testExplicitOverride_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\395780\\testExplicitOverride\\testExplicitOverride.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
