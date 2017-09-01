using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Coverage_arglist_pos_arglist_pos_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Coverage_arglist_pos_arglist_pos_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Coverage\\arglist_pos\\arglist_pos.cmd");
        }
    }
}
