using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_simplenonlocalexit_ro_simplenonlocalexit_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexit_ro_simplenonlocalexit_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexit_ro\\simplenonlocalexit_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
