using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgdeep_array_nz__il_dbgdeep_array_nz_
    {
        [Fact]
        public void _tailcall__il_dbgdeep_array_nz__il_dbgdeep_array_nz_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgdeep_array_nz\\_il_dbgdeep_array_nz.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
