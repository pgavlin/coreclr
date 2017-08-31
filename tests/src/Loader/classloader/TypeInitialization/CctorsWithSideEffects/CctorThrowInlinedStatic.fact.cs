using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_CctorThrowInlinedStatic_CctorThrowInlinedStatic_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_CctorThrowInlinedStatic_CctorThrowInlinedStatic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\CctorThrowInlinedStatic\\CctorThrowInlinedStatic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
