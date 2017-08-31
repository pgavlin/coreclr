using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalgotoinatryblockinahandler_do_nonlocalgotoinatryblockinahandler_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalgotoinatryblockinahandler_do_nonlocalgotoinatryblockinahandler_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalgotoinatryblockinahandler_do\\nonlocalgotoinatryblockinahandler_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
