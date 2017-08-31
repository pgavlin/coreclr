using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_c__opt_dbgrefarg_c_
    {
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_c__opt_dbgrefarg_c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_c\\_opt_dbgrefarg_c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
