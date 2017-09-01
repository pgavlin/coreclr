using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_nonlocalgotoinatryblockinahandler_ro_nonlocalgotoinatryblockinahandler_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalgotoinatryblockinahandler_ro_nonlocalgotoinatryblockinahandler_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalgotoinatryblockinahandler_ro\\nonlocalgotoinatryblockinahandler_ro.cmd");
        }
    }
}
