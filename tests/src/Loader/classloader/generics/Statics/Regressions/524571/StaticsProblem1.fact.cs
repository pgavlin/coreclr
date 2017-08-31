using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Statics_Regressions_524571_StaticsProblem1_StaticsProblem1_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Statics_Regressions_524571_StaticsProblem1_StaticsProblem1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Statics\\Regressions\\524571\\StaticsProblem1\\StaticsProblem1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
