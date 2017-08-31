using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalGetBits_DecimalGetBits_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalGetBits_DecimalGetBits_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalGetBits\\DecimalGetBits.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
