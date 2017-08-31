using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_CctorThrowLDFTNStaticMethod_CctorThrowLDFTNStaticMethod_
    {
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_CctorThrowLDFTNStaticMethod_CctorThrowLDFTNStaticMethod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\CctorThrowLDFTNStaticMethod\\CctorThrowLDFTNStaticMethod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
