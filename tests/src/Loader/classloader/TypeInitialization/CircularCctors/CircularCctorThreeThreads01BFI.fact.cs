using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CircularCctors_CircularCctorThreeThreads01BFI_CircularCctorThreeThreads01BFI_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorThreeThreads01BFI_CircularCctorThreeThreads01BFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorThreeThreads01BFI\\CircularCctorThreeThreads01BFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
