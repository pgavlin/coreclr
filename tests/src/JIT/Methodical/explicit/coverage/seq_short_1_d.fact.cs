using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_coverage_seq_short_1_d_seq_short_1_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_seq_short_1_d_seq_short_1_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\seq_short_1_d\\seq_short_1_d.cmd");
        }
    }
}
