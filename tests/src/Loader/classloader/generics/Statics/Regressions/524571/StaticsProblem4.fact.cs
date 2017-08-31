using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Statics_Regressions_524571_StaticsProblem4_StaticsProblem4_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Statics_Regressions_524571_StaticsProblem4_StaticsProblem4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Statics\\Regressions\\524571\\StaticsProblem4\\StaticsProblem4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
