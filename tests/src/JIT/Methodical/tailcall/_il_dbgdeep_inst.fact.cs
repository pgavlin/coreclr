using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgdeep_inst__il_dbgdeep_inst_
    {
        [Fact]
        public void _tailcall__il_dbgdeep_inst__il_dbgdeep_inst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgdeep_inst\\_il_dbgdeep_inst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
