using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_vsw395780_testExplicitOverride2_testExplicitOverride2_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_vsw395780_testExplicitOverride2_testExplicitOverride2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\vsw395780\\testExplicitOverride2\\testExplicitOverride2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
