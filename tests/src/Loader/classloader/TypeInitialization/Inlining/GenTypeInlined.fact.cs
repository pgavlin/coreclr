using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_Inlining_GenTypeInlined_GenTypeInlined_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_GenTypeInlined_GenTypeInlined_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\GenTypeInlined\\GenTypeInlined.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
