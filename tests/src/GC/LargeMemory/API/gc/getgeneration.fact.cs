using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _API_gc_getgeneration_getgeneration_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _API_gc_getgeneration_getgeneration_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\getgeneration\\getgeneration.cmd");
        }
    }
}
