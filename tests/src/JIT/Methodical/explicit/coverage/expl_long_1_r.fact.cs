using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_coverage_expl_long_1_r_expl_long_1_r_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_expl_long_1_r_expl_long_1_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\expl_long_1_r\\expl_long_1_r.cmd");
        }
    }
}
