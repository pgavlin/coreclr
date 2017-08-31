using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_421439_Test_Test_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_421439_Test_Test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\421439\\Test\\Test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
