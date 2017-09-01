using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_SEH__il_relcatchfault_jmp__il_relcatchfault_jmp_
    {
        [Fact]
        public void _Invoke_SEH__il_relcatchfault_jmp__il_relcatchfault_jmp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_relcatchfault_jmp\\_il_relcatchfault_jmp.cmd");
        }
    }
}
