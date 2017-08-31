using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalgotoinatryblockinahandler_d_nonlocalgotoinatryblockinahandler_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalgotoinatryblockinahandler_d_nonlocalgotoinatryblockinahandler_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalgotoinatryblockinahandler_d\\nonlocalgotoinatryblockinahandler_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
