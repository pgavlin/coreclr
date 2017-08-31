using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Statics_Regressions_524571_StaticsProblem3_StaticsProblem3_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Statics_Regressions_524571_StaticsProblem3_StaticsProblem3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Statics\\Regressions\\524571\\StaticsProblem3\\StaticsProblem3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
