using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_doublinknoleak_doublinknoleak_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _DoublinkList_doublinknoleak_doublinknoleak_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\doublinknoleak\\doublinknoleak.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
