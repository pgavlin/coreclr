using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_vsw531159_vsw531159_vsw531159_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw531159_vsw531159_vsw531159_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw531159\\vsw531159\\vsw531159.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
