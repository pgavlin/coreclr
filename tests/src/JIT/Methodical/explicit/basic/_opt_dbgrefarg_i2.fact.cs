using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_i2__opt_dbgrefarg_i2_
    {
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_i2__opt_dbgrefarg_i2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_i2\\_opt_dbgrefarg_i2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
