using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_relrecurse_jmp__il_relrecurse_jmp_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relrecurse_jmp__il_relrecurse_jmp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_jmp\\_il_relrecurse_jmp.cmd");
        }
    }
}
