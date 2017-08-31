using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _rvastatics_rvastatic5_rvastatic5_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic5_rvastatic5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic5\\rvastatic5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
