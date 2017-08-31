using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_Inlining_Inlined_Inlined_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_Inlined_Inlined_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\Inlined\\Inlined.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
