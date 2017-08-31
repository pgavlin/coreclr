using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_536564_vsw536564_vsw536564_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_536564_vsw536564_vsw536564_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\536564\\vsw536564\\vsw536564.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
