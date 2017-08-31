using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_405223_vsw405223_vsw405223_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_405223_vsw405223_vsw405223_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\405223\\vsw405223\\vsw405223.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
