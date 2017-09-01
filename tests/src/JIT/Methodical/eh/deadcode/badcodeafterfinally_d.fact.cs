using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_badcodeafterfinally_d_badcodeafterfinally_d_
    {
        [ActiveIssue("2444")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfinally_d_badcodeafterfinally_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfinally_d\\badcodeafterfinally_d.cmd");
        }
    }
}
