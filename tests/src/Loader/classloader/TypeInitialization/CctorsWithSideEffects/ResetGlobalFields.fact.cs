using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_ResetGlobalFields_ResetGlobalFields_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_ResetGlobalFields_ResetGlobalFields_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\ResetGlobalFields\\ResetGlobalFields.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
