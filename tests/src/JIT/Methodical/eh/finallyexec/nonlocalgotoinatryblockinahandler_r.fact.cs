using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalgotoinatryblockinahandler_r_nonlocalgotoinatryblockinahandler_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalgotoinatryblockinahandler_r_nonlocalgotoinatryblockinahandler_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalgotoinatryblockinahandler_r\\nonlocalgotoinatryblockinahandler_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
