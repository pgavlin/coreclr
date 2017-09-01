using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_simplenonlocalexit_do_simplenonlocalexit_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexit_do_simplenonlocalexit_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexit_do\\simplenonlocalexit_do.cmd");
        }
    }
}
