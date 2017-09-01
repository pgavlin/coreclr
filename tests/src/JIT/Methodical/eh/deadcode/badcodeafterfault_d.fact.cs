using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_badcodeafterfault_d_badcodeafterfault_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfault_d_badcodeafterfault_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfault_d\\badcodeafterfault_d.cmd");
        }
    }
}
