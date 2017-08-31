using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_dbgint32_neg_range__il_dbgint32_neg_range_
    {
        [Fact]
        public void _Arrays_range__il_dbgint32_neg_range__il_dbgint32_neg_range_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_dbgint32_neg_range\\_il_dbgint32_neg_range.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
