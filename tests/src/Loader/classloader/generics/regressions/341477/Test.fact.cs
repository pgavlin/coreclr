using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_341477_Test_Test_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_341477_Test_Test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\341477\\Test\\Test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
