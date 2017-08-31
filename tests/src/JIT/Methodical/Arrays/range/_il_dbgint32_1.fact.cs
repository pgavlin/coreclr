using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_dbgint32_1__il_dbgint32_1_
    {
        [Fact]
        public void _Arrays_range__il_dbgint32_1__il_dbgint32_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_dbgint32_1\\_il_dbgint32_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
