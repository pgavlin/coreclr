using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_revcomp_revcomp_revcomp_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Fact]
        public void _CodeQuality_BenchmarksGame_revcomp_revcomp_revcomp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\revcomp\\revcomp\\revcomp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
