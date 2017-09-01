using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_Inlining_Inlined_Multinested_Inlined_Multinested_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_Inlined_Multinested_Inlined_Multinested_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\Inlined_Multinested\\Inlined_Multinested.cmd");
        }
    }
}
