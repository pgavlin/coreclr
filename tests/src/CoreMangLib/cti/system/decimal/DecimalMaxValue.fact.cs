using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalMaxValue_DecimalMaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalMaxValue_DecimalMaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalMaxValue\\DecimalMaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
