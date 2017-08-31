using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeInitialization_Inlining_Inlined_Multinested_Inlined_Multinested_
    {
        [OuterLoop]
        [Fact]
        public void _TypeInitialization_Inlining_Inlined_Multinested_Inlined_Multinested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeInitialization\\Inlining\\Inlined_Multinested\\Inlined_Multinested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
