using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_Inlining_Inlined_Inlined_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_Inlined_Inlined_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\Inlined\\Inlined.cmd");
        }
    }
}
