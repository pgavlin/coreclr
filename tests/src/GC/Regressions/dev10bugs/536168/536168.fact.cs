using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _dev10bugs_536168_536168_536168_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _dev10bugs_536168_536168_536168_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\dev10bugs\\536168\\536168\\536168.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
