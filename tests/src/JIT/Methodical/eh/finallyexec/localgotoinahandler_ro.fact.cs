using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_localgotoinahandler_ro_localgotoinahandler_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_localgotoinahandler_ro_localgotoinahandler_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\localgotoinahandler_ro\\localgotoinahandler_ro.cmd");
        }
    }
}
