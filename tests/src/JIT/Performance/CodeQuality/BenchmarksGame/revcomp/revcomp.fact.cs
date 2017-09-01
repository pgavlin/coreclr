using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_BenchmarksGame_revcomp_revcomp_revcomp_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Fact]
        public void _CodeQuality_BenchmarksGame_revcomp_revcomp_revcomp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\revcomp\\revcomp\\revcomp.cmd");
        }
    }
}
