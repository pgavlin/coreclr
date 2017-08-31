using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_i4__opt_dbgrefarg_i4_
    {
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_i4__opt_dbgrefarg_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_i4\\_opt_dbgrefarg_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
