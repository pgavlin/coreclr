using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_i1__opt_dbgrefarg_i1_
    {
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_i1__opt_dbgrefarg_i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_i1\\_opt_dbgrefarg_i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
