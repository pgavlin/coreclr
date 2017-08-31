using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalEquals3_DecimalEquals3_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalEquals3_DecimalEquals3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalEquals3\\DecimalEquals3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
