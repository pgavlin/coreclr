using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_o__opt_dbgrefarg_o_
    {
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_o__opt_dbgrefarg_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_o\\_opt_dbgrefarg_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
