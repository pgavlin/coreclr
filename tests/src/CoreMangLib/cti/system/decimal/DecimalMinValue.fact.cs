using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalMinValue_DecimalMinValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalMinValue_DecimalMinValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalMinValue\\DecimalMinValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
