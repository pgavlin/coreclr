using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_SEH__il_dbgcatchfault_jmp__il_dbgcatchfault_jmp_
    {
        [Fact]
        public void _Invoke_SEH__il_dbgcatchfault_jmp__il_dbgcatchfault_jmp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_dbgcatchfault_jmp\\_il_dbgcatchfault_jmp.cmd");
        }
    }
}
