using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Statics_Regressions_524571_StaticsProblem2_StaticsProblem2_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Statics_Regressions_524571_StaticsProblem2_StaticsProblem2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Statics\\Regressions\\524571\\StaticsProblem2\\StaticsProblem2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
