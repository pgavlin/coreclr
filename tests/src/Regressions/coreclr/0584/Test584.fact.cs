using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0584_Test584_Test584_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _0584_Test584_Test584_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0584\\Test584\\Test584.cmd");
        }
    }
}
