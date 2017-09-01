using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _API_gc_suppressfinalize_suppressfinalize_
    {
        [ActiveIssue("3392, test is useful to have because it can be run manually when making changes to the GC that can have effects in OOM scenarios, but not appropriate to run on our current test infrastructure.")]//, TestArchitectures.X86)]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _API_gc_suppressfinalize_suppressfinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\API\\gc\\suppressfinalize\\suppressfinalize.cmd");
        }
    }
}
