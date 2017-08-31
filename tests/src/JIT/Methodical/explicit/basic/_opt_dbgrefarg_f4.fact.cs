using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_f4__opt_dbgrefarg_f4_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_f4__opt_dbgrefarg_f4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_f4\\_opt_dbgrefarg_f4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
