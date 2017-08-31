using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_simplenonlocalexit_r_simplenonlocalexit_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexit_r_simplenonlocalexit_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexit_r\\simplenonlocalexit_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
