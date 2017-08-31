using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_simplenonlocalexit_d_simplenonlocalexit_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexit_d_simplenonlocalexit_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexit_d\\simplenonlocalexit_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
