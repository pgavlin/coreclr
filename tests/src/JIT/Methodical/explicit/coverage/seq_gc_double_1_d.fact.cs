using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _explicit_coverage_seq_gc_double_1_d_seq_gc_double_1_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _explicit_coverage_seq_gc_double_1_d_seq_gc_double_1_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\coverage\\seq_gc_double_1_d\\seq_gc_double_1_d.cmd");
        }
    }
}
