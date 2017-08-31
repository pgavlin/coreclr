using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_Inlining_GenMethInlined_Multinested_GenMethInlined_Multinested_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_GenMethInlined_Multinested_GenMethInlined_Multinested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\GenMethInlined_Multinested\\GenMethInlined_Multinested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
