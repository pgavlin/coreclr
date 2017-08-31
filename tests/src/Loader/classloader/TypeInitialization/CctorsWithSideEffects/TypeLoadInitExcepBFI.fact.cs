using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_TypeLoadInitExcepBFI_TypeLoadInitExcepBFI_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_TypeLoadInitExcepBFI_TypeLoadInitExcepBFI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\TypeLoadInitExcepBFI\\TypeLoadInitExcepBFI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
