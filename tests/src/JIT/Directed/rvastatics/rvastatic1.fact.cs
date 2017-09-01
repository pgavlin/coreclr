using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _rvastatics_rvastatic1_rvastatic1_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic1_rvastatic1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic1\\rvastatic1.cmd");
        }
    }
}
