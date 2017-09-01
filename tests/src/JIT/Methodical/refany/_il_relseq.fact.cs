using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany__il_relseq__il_relseq_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__il_relseq__il_relseq_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relseq\\_il_relseq.cmd");
        }
    }
}
