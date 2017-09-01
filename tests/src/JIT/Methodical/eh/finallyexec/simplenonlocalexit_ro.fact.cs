using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_simplenonlocalexit_ro_simplenonlocalexit_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexit_ro_simplenonlocalexit_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexit_ro\\simplenonlocalexit_ro.cmd");
        }
    }
}
