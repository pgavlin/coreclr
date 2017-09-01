using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_global_il_d_global_il_d_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _cctor_misc_global_il_d_global_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\global_il_d\\global_il_d.cmd");
        }
    }
}
