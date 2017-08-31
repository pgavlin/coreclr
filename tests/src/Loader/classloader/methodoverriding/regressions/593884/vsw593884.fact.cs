using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _methodoverriding_regressions_593884_vsw593884_vsw593884_
    {
        [OuterLoop]
        [Fact]
        public void _methodoverriding_regressions_593884_vsw593884_vsw593884_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\methodoverriding\\regressions\\593884\\vsw593884\\vsw593884.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
