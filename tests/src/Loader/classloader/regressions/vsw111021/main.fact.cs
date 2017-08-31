using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_vsw111021_main_main_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw111021_main_main_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw111021\\main\\main.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
