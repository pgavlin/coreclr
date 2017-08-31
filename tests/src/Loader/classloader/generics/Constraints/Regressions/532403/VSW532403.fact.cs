using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Constraints_Regressions_532403_VSW532403_VSW532403_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Constraints_Regressions_532403_VSW532403_VSW532403_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Constraints\\Regressions\\532403\\VSW532403\\VSW532403.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
