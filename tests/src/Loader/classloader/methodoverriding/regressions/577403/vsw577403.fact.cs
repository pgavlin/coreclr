using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _methodoverriding_regressions_577403_vsw577403_vsw577403_
    {
        [OuterLoop]
        [Fact]
        public void _methodoverriding_regressions_577403_vsw577403_vsw577403_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\methodoverriding\\regressions\\577403\\vsw577403\\vsw577403.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
