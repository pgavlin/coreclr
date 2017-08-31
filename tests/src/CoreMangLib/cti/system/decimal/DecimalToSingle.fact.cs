using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalToSingle_DecimalToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalToSingle_DecimalToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalToSingle\\DecimalToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
