using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalTruncate_DecimalTruncate_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalTruncate_DecimalTruncate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalTruncate\\DecimalTruncate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
