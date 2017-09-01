using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_importer_Desktop_bleref_il_r_bleref_il_r_
    {
        [ActiveIssue("4851")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_bleref_il_r_bleref_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\bleref_il_r\\bleref_il_r.cmd");
        }
    }
}
