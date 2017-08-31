using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_Inlining_GenMethInlined_GenMethInlined_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_GenMethInlined_GenMethInlined_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\GenMethInlined\\GenMethInlined.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
