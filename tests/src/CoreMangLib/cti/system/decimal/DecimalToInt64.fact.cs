using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalToInt64_DecimalToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalToInt64_DecimalToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalToInt64\\DecimalToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
