using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_dbgcatchfault_jmp__il_dbgcatchfault_jmp_
    {
        [Fact]
        public void _Invoke_SEH__il_dbgcatchfault_jmp__il_dbgcatchfault_jmp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_dbgcatchfault_jmp\\_il_dbgcatchfault_jmp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
