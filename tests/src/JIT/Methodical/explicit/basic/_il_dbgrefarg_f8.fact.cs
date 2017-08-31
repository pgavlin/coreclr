using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefarg_f8__il_dbgrefarg_f8_
    {
        [Fact]
        public void _explicit_basic__il_dbgrefarg_f8__il_dbgrefarg_f8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefarg_f8\\_il_dbgrefarg_f8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
