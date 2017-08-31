using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalRemainder_DecimalRemainder_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalRemainder_DecimalRemainder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalRemainder\\DecimalRemainder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
