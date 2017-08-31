using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_CctorsWithSideEffects_CctorOpenFile_CctorOpenFile_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_CctorsWithSideEffects_CctorOpenFile_CctorOpenFile_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\CctorsWithSideEffects\\CctorOpenFile\\CctorOpenFile.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
