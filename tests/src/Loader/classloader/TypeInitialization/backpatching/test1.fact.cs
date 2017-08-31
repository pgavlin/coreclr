using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_backpatching_test1_test1_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_backpatching_test1_test1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\backpatching\\test1\\test1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
