using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_ThisNulllPointer_CctorZeroVal03_CctorZeroVal03_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_ThisNulllPointer_CctorZeroVal03_CctorZeroVal03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\ThisNulllPointer\\CctorZeroVal03\\CctorZeroVal03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
