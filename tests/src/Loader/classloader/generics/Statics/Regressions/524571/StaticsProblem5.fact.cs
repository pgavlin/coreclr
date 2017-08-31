using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Statics_Regressions_524571_StaticsProblem5_StaticsProblem5_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Statics_Regressions_524571_StaticsProblem5_StaticsProblem5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Statics\\Regressions\\524571\\StaticsProblem5\\StaticsProblem5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
