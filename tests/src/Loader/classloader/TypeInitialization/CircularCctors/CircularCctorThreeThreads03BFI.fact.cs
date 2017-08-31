using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CircularCctors_CircularCctorThreeThreads03BFI_CircularCctorThreeThreads03BFI_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorThreeThreads03BFI_CircularCctorThreeThreads03BFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorThreeThreads03BFI\\CircularCctorThreeThreads03BFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
