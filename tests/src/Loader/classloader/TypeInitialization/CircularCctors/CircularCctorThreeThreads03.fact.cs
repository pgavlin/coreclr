using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CircularCctors_CircularCctorThreeThreads03_CircularCctorThreeThreads03_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorThreeThreads03_CircularCctorThreeThreads03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorThreeThreads03\\CircularCctorThreeThreads03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
