using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0584_Test584_Test584_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _0584_Test584_Test584_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0584\\Test584\\Test584.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
