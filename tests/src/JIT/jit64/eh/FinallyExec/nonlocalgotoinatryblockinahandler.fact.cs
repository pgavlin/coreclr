using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nonlocalgotoinatryblockinahandler_nonlocalgotoinatryblockinahandler_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalgotoinatryblockinahandler_nonlocalgotoinatryblockinahandler_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalgotoinatryblockinahandler\\nonlocalgotoinatryblockinahandler.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
