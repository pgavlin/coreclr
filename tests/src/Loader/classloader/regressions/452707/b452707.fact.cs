using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_452707_b452707_b452707_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_452707_b452707_b452707_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\452707\\b452707\\b452707.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
