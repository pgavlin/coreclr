using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_UntrustedCodeBFI_UntrustedCodeBFI_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_UntrustedCodeBFI_UntrustedCodeBFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\UntrustedCodeBFI\\UntrustedCodeBFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
