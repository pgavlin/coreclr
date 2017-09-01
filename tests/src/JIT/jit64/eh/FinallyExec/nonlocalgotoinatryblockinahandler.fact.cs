using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nonlocalgotoinatryblockinahandler_nonlocalgotoinatryblockinahandler_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalgotoinatryblockinahandler_nonlocalgotoinatryblockinahandler_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalgotoinatryblockinahandler\\nonlocalgotoinatryblockinahandler.cmd");
        }
    }
}
