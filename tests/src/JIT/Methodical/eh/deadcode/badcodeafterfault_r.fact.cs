using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_badcodeafterfault_r_badcodeafterfault_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfault_r_badcodeafterfault_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfault_r\\badcodeafterfault_r.cmd");
        }
    }
}
