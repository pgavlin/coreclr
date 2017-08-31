using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgdeep_array__il_dbgdeep_array_
    {
        [Fact]
        public void _tailcall__il_dbgdeep_array__il_dbgdeep_array_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgdeep_array\\_il_dbgdeep_array.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
