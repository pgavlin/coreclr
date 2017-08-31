using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_ThisNulllPointer_CctorZeroVal02_CctorZeroVal02_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_ThisNulllPointer_CctorZeroVal02_CctorZeroVal02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\ThisNulllPointer\\CctorZeroVal02\\CctorZeroVal02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
