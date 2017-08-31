using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalSubtract_DecimalSubtract_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalSubtract_DecimalSubtract_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalSubtract\\DecimalSubtract.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
