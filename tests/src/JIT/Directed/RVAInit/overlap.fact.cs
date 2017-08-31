using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_overlap_overlap_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _RVAInit_overlap_overlap_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\overlap\\overlap.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
