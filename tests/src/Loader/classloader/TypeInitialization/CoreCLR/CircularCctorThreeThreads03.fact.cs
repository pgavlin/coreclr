using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CoreCLR_CircularCctorThreeThreads03_CircularCctorThreeThreads03_
    {
        [Fact]
        public void _TypeInitialization_CoreCLR_CircularCctorThreeThreads03_CircularCctorThreeThreads03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CoreCLR\\CircularCctorThreeThreads03\\CircularCctorThreeThreads03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
