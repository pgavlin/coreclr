using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_k_nucleotide_k_nucleotide_k_nucleotide_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Fact]
        public void _CodeQuality_BenchmarksGame_k_nucleotide_k_nucleotide_k_nucleotide_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\k-nucleotide\\k-nucleotide\\k-nucleotide.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
