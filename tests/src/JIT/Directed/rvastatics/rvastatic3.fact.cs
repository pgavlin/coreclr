using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _rvastatics_rvastatic3_rvastatic3_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic3_rvastatic3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic3\\rvastatic3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
