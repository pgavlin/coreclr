using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_dbgrecurse_jmp__il_dbgrecurse_jmp_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbgrecurse_jmp__il_dbgrecurse_jmp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgrecurse_jmp\\_il_dbgrecurse_jmp.cmd");
        }
    }
}
