using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CircularCctors_CircularCctorThreeThreads02BFI_CircularCctorThreeThreads02BFI_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorThreeThreads02BFI_CircularCctorThreeThreads02BFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorThreeThreads02BFI\\CircularCctorThreeThreads02BFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
