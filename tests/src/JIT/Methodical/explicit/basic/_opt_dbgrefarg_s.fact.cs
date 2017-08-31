using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_dbgrefarg_s__opt_dbgrefarg_s_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__opt_dbgrefarg_s__opt_dbgrefarg_s_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_dbgrefarg_s\\_opt_dbgrefarg_s.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
