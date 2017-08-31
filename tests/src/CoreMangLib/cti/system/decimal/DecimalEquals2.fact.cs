using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalEquals2_DecimalEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalEquals2_DecimalEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalEquals2\\DecimalEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
