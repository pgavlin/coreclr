using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_ThisNulllPointer_CctorZeroVal01_CctorZeroVal01_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_ThisNulllPointer_CctorZeroVal01_CctorZeroVal01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\ThisNulllPointer\\CctorZeroVal01\\CctorZeroVal01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
