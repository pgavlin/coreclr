using CoreclrTestLib;
using Xunit;

namespace Loader_regressions
{
    class _classloader_main_main_
    {
        [OuterLoop]
        [Fact]
        public void _classloader_main_main_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\regressions\\classloader\\main\\main.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
