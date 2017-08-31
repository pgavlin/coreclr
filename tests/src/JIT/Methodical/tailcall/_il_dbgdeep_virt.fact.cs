using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgdeep_virt__il_dbgdeep_virt_
    {
        [Fact]
        public void _tailcall__il_dbgdeep_virt__il_dbgdeep_virt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgdeep_virt\\_il_dbgdeep_virt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
