using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_loopstrswitchgoto_ro_loopstrswitchgoto_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_loopstrswitchgoto_ro_loopstrswitchgoto_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\loopstrswitchgoto_ro\\loopstrswitchgoto_ro.cmd");
        }
    }
}
