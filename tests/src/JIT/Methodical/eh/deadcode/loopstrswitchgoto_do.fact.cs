using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_loopstrswitchgoto_do_loopstrswitchgoto_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_loopstrswitchgoto_do_loopstrswitchgoto_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\loopstrswitchgoto_do\\loopstrswitchgoto_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
