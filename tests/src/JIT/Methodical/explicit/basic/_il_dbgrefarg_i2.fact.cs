using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefarg_i2__il_dbgrefarg_i2_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__il_dbgrefarg_i2__il_dbgrefarg_i2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefarg_i2\\_il_dbgrefarg_i2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
