using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _Allocation_largeexceptiontest_largeexceptiontest_
    {
        [ActiveIssue("3392, test is useful to have because it can be run manually when making changes to the GC that can have effects in OOM scenarios, but not appropriate to run on our current test infrastructure.")]//, TestArchitectures.X86)]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Allocation_largeexceptiontest_largeexceptiontest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\Allocation\\largeexceptiontest\\largeexceptiontest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
