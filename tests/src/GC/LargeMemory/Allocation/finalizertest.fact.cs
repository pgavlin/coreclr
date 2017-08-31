using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _Allocation_finalizertest_finalizertest_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Allocation_finalizertest_finalizertest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\Allocation\\finalizertest\\finalizertest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
