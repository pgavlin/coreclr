using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _API_gc_reregisterforfinalize_reregisterforfinalize_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _API_gc_reregisterforfinalize_reregisterforfinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\reregisterforfinalize\\reregisterforfinalize.cmd");
        }
    }
}
