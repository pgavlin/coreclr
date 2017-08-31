using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_144257_vsw144257_vsw144257_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_144257_vsw144257_vsw144257_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\144257\\vsw144257\\vsw144257.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
