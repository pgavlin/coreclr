using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dd52_dd52_dd52_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dd52_dd52_dd52_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dd52\\dd52\\dd52.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
