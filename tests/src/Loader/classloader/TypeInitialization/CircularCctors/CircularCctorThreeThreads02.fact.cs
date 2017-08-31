using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CircularCctors_CircularCctorThreeThreads02_CircularCctorThreeThreads02_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorThreeThreads02_CircularCctorThreeThreads02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorThreeThreads02\\CircularCctorThreeThreads02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
