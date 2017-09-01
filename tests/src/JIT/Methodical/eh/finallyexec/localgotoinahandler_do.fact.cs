using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_localgotoinahandler_do_localgotoinahandler_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_localgotoinahandler_do_localgotoinahandler_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\localgotoinahandler_do\\localgotoinahandler_do.cmd");
        }
    }
}
