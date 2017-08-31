using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_vsw188290_vsw188290_vsw188290_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw188290_vsw188290_vsw188290_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw188290\\vsw188290\\vsw188290.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
