using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_loopstrswitchgoto_do_loopstrswitchgoto_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_loopstrswitchgoto_do_loopstrswitchgoto_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\loopstrswitchgoto_do\\loopstrswitchgoto_do.cmd");
        }
    }
}
