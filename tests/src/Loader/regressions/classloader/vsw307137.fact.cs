using CoreclrTestLib;
using Xunit;

namespace Loader_regressions
{
    class _classloader_vsw307137_vsw307137_
    {
        [OuterLoop]
        [Fact]
        public void _classloader_vsw307137_vsw307137_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\regressions\\classloader\\vsw307137\\vsw307137.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
