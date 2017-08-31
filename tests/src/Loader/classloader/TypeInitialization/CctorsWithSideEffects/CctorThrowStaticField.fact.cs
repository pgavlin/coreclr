using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_CctorThrowStaticField_CctorThrowStaticField_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_CctorThrowStaticField_CctorThrowStaticField_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\CctorThrowStaticField\\CctorThrowStaticField.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
