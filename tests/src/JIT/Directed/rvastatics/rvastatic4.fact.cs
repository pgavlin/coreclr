using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _rvastatics_rvastatic4_rvastatic4_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic4_rvastatic4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic4\\rvastatic4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
