using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_badcodeafterfinally_r_badcodeafterfinally_r_
    {
        [ActiveIssue("2444")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfinally_r_badcodeafterfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfinally_r\\badcodeafterfinally_r.cmd");
        }
    }
}
