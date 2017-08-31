using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_440935_Test_Test_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_440935_Test_Test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\440935\\Test\\Test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
