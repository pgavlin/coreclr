using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalMinusOne_DecimalMinusOne_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalMinusOne_DecimalMinusOne_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalMinusOne\\DecimalMinusOne.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
