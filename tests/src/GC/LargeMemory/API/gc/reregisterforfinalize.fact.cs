using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _API_gc_reregisterforfinalize_reregisterforfinalize_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _API_gc_reregisterforfinalize_reregisterforfinalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\reregisterforfinalize\\reregisterforfinalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
