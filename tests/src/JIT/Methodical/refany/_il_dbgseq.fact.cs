using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany__il_dbgseq__il_dbgseq_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__il_dbgseq__il_dbgseq_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgseq\\_il_dbgseq.cmd");
        }
    }
}
