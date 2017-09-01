using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_BenchmarksGame_k_nucleotide_k_nucleotide_k_nucleotide_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Fact]
        public void _CodeQuality_BenchmarksGame_k_nucleotide_k_nucleotide_k_nucleotide_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\k-nucleotide\\k-nucleotide\\k-nucleotide.cmd");
        }
    }
}
