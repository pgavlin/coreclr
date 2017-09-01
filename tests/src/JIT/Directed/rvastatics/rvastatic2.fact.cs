using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _rvastatics_rvastatic2_rvastatic2_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _rvastatics_rvastatic2_rvastatic2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\rvastatics\\rvastatic2\\rvastatic2.cmd");
        }
    }
}
