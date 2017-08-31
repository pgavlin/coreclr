using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _API_gc_gettotalmemory_gettotalmemory_
    {
        [ActiveIssue("3392, test is useful to have because it can be run manually when making changes to the GC that can have effects in OOM scenarios, but not appropriate to run on our current test infrastructure.")]//, TestArchitectures.X86)]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _API_gc_gettotalmemory_gettotalmemory_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\gettotalmemory\\gettotalmemory.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
