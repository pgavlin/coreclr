using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalToByte1_DecimalToByte1_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalToByte1_DecimalToByte1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalToByte1\\DecimalToByte1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
