using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_vsw514968_vsw514968_vsw514968_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_vsw514968_vsw514968_vsw514968_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\vsw514968\\vsw514968\\vsw514968.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
