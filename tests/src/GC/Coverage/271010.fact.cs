using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    public class _271010_271010_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _271010_271010_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Coverage\\271010\\271010.cmd");
        }
    }
}
