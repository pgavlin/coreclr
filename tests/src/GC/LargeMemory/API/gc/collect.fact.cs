using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _API_gc_collect_collect_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _API_gc_collect_collect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\collect\\collect.cmd");
        }
    }
}
