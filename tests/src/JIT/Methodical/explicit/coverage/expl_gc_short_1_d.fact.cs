using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_coverage_expl_gc_short_1_d_expl_gc_short_1_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_expl_gc_short_1_d_expl_gc_short_1_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\expl_gc_short_1_d\\expl_gc_short_1_d.cmd");
        }
    }
}
