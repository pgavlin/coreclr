using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_307137_vsw307137_vsw307137_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_307137_vsw307137_vsw307137_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\307137\\vsw307137\\vsw307137.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
