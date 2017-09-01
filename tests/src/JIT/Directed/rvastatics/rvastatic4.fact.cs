using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _rvastatics_rvastatic4_rvastatic4_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic4_rvastatic4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic4\\rvastatic4.cmd");
        }
    }
}
