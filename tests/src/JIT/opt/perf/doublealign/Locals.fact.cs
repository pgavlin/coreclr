using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _perf_doublealign_Locals_Locals_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _perf_doublealign_Locals_Locals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\perf\\doublealign\\Locals\\Locals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
