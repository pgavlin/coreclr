using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    public class _dev10bugs_536168_536168_536168_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _dev10bugs_536168_536168_536168_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Regressions\\dev10bugs\\536168\\536168\\536168.cmd");
        }
    }
}
