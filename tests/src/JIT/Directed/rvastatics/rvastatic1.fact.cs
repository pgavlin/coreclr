using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _rvastatics_rvastatic1_rvastatic1_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic1_rvastatic1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic1\\rvastatic1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
