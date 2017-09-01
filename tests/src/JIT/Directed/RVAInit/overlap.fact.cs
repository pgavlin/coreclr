using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_overlap_overlap_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _RVAInit_overlap_overlap_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\overlap\\overlap.cmd");
        }
    }
}
