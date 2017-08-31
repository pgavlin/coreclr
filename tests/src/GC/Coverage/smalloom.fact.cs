using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    class _smalloom_smalloom_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _smalloom_smalloom_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Coverage\\smalloom\\smalloom.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
