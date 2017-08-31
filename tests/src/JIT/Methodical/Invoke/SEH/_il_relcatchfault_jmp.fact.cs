using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_relcatchfault_jmp__il_relcatchfault_jmp_
    {
        [Fact]
        public void _Invoke_SEH__il_relcatchfault_jmp__il_relcatchfault_jmp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_relcatchfault_jmp\\_il_relcatchfault_jmp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
