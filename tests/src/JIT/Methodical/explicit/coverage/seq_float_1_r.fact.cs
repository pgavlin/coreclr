using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_coverage_seq_float_1_r_seq_float_1_r_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_seq_float_1_r_seq_float_1_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\seq_float_1_r\\seq_float_1_r.cmd");
        }
    }
}
