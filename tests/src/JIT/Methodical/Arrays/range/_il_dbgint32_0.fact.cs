using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_dbgint32_0__il_dbgint32_0_
    {
        [Fact]
        public void _Arrays_range__il_dbgint32_0__il_dbgint32_0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_dbgint32_0\\_il_dbgint32_0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
