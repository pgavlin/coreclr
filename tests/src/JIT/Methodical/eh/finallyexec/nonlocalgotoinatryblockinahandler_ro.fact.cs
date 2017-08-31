using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalgotoinatryblockinahandler_ro_nonlocalgotoinatryblockinahandler_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalgotoinatryblockinahandler_ro_nonlocalgotoinatryblockinahandler_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalgotoinatryblockinahandler_ro\\nonlocalgotoinatryblockinahandler_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
