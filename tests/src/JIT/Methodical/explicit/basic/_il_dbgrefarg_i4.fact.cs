using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefarg_i4__il_dbgrefarg_i4_
    {
        [Fact]
        public void _explicit_basic__il_dbgrefarg_i4__il_dbgrefarg_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefarg_i4\\_il_dbgrefarg_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
