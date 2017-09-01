using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_importer_Desktop_ldelemnullarr1_il_d_ldelemnullarr1_il_d_
    {
        [ActiveIssue("4851")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_ldelemnullarr1_il_d_ldelemnullarr1_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\ldelemnullarr1_il_d\\ldelemnullarr1_il_d.cmd");
        }
    }
}
