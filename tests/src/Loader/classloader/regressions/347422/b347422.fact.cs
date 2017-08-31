using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_347422_b347422_b347422_
    {
        [Fact]
        public void _regressions_347422_b347422_b347422_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\347422\\b347422\\b347422.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
