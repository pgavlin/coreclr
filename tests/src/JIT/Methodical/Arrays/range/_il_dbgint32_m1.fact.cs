using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_dbgint32_m1__il_dbgint32_m1_
    {
        [Fact]
        public void _Arrays_range__il_dbgint32_m1__il_dbgint32_m1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_dbgint32_m1\\_il_dbgint32_m1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
