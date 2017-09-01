using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_Inlining_GenMethInlined_Multinested_GenMethInlined_Multinested_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_GenMethInlined_Multinested_GenMethInlined_Multinested_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\GenMethInlined_Multinested\\GenMethInlined_Multinested.cmd");
        }
    }
}
