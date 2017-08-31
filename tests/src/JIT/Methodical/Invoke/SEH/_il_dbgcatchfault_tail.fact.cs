using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__il_dbgcatchfault_tail__il_dbgcatchfault_tail_
    {
        [Fact]
        public void _Invoke_SEH__il_dbgcatchfault_tail__il_dbgcatchfault_tail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_il_dbgcatchfault_tail\\_il_dbgcatchfault_tail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
