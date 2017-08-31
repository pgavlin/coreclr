using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _API_gc_getgeneration_getgeneration_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _API_gc_getgeneration_getgeneration_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\getgeneration\\getgeneration.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
