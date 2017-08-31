using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_TypeLoadInitExcep_TypeLoadInitExcep_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_TypeLoadInitExcep_TypeLoadInitExcep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\TypeLoadInitExcep\\TypeLoadInitExcep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
