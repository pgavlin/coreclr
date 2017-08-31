using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalToString3_DecimalToString3_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalToString3_DecimalToString3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalToString3\\DecimalToString3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
