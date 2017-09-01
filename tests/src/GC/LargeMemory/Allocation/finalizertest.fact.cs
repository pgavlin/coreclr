using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _Allocation_finalizertest_finalizertest_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Allocation_finalizertest_finalizertest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\Allocation\\finalizertest\\finalizertest.cmd");
        }
    }
}
