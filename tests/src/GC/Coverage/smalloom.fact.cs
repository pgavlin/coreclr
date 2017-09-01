using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    public class _smalloom_smalloom_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _smalloom_smalloom_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Coverage\\smalloom\\smalloom.cmd");
        }
    }
}
