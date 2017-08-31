using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalEquals1_DecimalEquals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalEquals1_DecimalEquals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalEquals1\\DecimalEquals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
