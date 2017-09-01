using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _perf_doublealign_Locals_Locals_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _perf_doublealign_Locals_Locals_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\perf\\doublealign\\Locals\\Locals.cmd");
        }
    }
}
