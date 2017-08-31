using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_dbgrecurse_jmp__il_dbgrecurse_jmp_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbgrecurse_jmp__il_dbgrecurse_jmp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgrecurse_jmp\\_il_dbgrecurse_jmp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
