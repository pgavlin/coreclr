using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_515341_vsw515341_vsw515341_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_515341_vsw515341_vsw515341_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\515341\\vsw515341\\vsw515341.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
