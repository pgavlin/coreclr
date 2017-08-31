using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CircularCctors_CircularCctorFourThreadsBFI_CircularCctorFourThreadsBFI_
    {
        [Fact]
        public void _TypeInitialization_CircularCctors_CircularCctorFourThreadsBFI_CircularCctorFourThreadsBFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CircularCctors\\CircularCctorFourThreadsBFI\\CircularCctorFourThreadsBFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
