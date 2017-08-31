using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_regexdna_regexdna_regexdna_
    {
        [Trait("ExcludeBuiltAgainstPackages", "*")]
        [Fact]
        public void _CodeQuality_BenchmarksGame_regexdna_regexdna_regexdna_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\regexdna\\regexdna\\regexdna.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
