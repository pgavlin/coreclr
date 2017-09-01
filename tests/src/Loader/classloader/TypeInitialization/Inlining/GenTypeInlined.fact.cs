using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _TypeInitialization_Inlining_GenTypeInlined_GenTypeInlined_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_GenTypeInlined_GenTypeInlined_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\GenTypeInlined\\GenTypeInlined.cmd");
        }
    }
}
