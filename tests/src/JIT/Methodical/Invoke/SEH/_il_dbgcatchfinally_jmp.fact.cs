using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_dbgcatchfinally_jmp__il_dbgcatchfinally_jmp_
    {
        [Fact]
        public void _Invoke_SEH__il_dbgcatchfinally_jmp__il_dbgcatchfinally_jmp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_dbgcatchfinally_jmp\\_il_dbgcatchfinally_jmp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
