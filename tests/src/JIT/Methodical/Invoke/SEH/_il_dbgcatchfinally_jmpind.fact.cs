using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_dbgcatchfinally_jmpind__il_dbgcatchfinally_jmpind_
    {
        [Fact]
        public void _Invoke_SEH__il_dbgcatchfinally_jmpind__il_dbgcatchfinally_jmpind_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_dbgcatchfinally_jmpind\\_il_dbgcatchfinally_jmpind.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
