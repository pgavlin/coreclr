using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relrecurse_jmp__il_relrecurse_jmp_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relrecurse_jmp__il_relrecurse_jmp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_jmp\\_il_relrecurse_jmp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
