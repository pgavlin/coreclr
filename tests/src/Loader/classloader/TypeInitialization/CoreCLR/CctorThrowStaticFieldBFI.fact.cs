using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CoreCLR_CctorThrowStaticFieldBFI_CctorThrowStaticFieldBFI_
    {
        [Fact]
        public void _TypeInitialization_CoreCLR_CctorThrowStaticFieldBFI_CctorThrowStaticFieldBFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CoreCLR\\CctorThrowStaticFieldBFI\\CctorThrowStaticFieldBFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
