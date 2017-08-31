using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgdeep_value__il_dbgdeep_value_
    {
        [Fact]
        public void _tailcall__il_dbgdeep_value__il_dbgdeep_value_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgdeep_value\\_il_dbgdeep_value.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
