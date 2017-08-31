using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_181424_test5_test5_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_181424_test5_test5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\181424\\test5\\test5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
