using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_Inlining_GenTypeInlined_Multinested_GenTypeInlined_Multinested_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_GenTypeInlined_Multinested_GenTypeInlined_Multinested_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\GenTypeInlined_Multinested\\GenTypeInlined_Multinested.cmd");
        }
    }
}
