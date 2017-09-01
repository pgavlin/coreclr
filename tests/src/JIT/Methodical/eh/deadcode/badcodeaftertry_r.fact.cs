using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_badcodeaftertry_r_badcodeaftertry_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeaftertry_r_badcodeaftertry_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeaftertry_r\\badcodeaftertry_r.cmd");
        }
    }
}
