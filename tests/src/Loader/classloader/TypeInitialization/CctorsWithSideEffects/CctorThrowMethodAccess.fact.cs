using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_CctorThrowMethodAccess_CctorThrowMethodAccess_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_CctorThrowMethodAccess_CctorThrowMethodAccess_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\CctorThrowMethodAccess\\CctorThrowMethodAccess.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
